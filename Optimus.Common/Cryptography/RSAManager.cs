using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Optimus.Common.Cryptography
{
    /// <summary>
    /// Thanks Moonlight-Angel
    /// </summary>
    public class RSAManager
    {
        private const string _RSAPublicKey =
            "MIIBUzANBgkqhkiG9w0BAQEFAAOCAUAAMIIBOwKCATIAqpzRrvO3We7EMi9cWYqdfb3rbdinTay+" +
            "hxQ6t3dOiJLY4NITxyeIuy97yZYOojOlXS2SuJ4cCHjCeLCQO1FwOz+nynQWcBWecz2QdbHD2Kz7" +
            "mNLd2qtZyEDO76rd7LaDOxRvgs9DsH9sfnCuKLKbd725xTLc7wRfJzOH9v9rTTYVXssXe7JUpTx8" +
            "nV8yKnTiq3WpzBeZT4C3ZCR18GBBCh3NmSTbze9i2KipgZnOwBvhskVlweuqZ1KNIKsQgipBFuyw" +
            "w68RGNYaAKofMVVio4amrGpCT5MM852jpHsgJJfOUHu6md1CnvdwDPbo/PKQUI0RLb0ezE5gsPma" +
            "s39QBw+DiaibUkk1aCkBxTOFqpIbjfLM2/4qA6GPcWUJxP3vmGoeCTMBLNEiPfLqVm86QzUCAwEA" +
            "AQ==";

        public static byte[] Encrypt(sbyte[] Key, string Salt, string UserName, string Password)
        {
            RSACryptoServiceProvider RSA = GetRSA(Key);
            string NewSalt = GetSalt(Salt);

            List<byte> Credentials = new List<byte>();

            Credentials.AddRange(Encoding.UTF8.GetBytes(NewSalt));
            Credentials.Add((byte)UserName.Length);
            Credentials.AddRange(Encoding.UTF8.GetBytes(UserName));
            Credentials.AddRange(Encoding.UTF8.GetBytes(Password));

            byte[] Encrypted = RSA.Encrypt(Credentials.ToArray(), false);
            //List<sbyte> test = new List<sbyte>();

            //foreach (byte value in Encrypted)
            //{
            //    test.Add((sbyte)value);
            //}
            sbyte[] EncryptedSigned = new sbyte[Encrypted.Length];
            Buffer.BlockCopy(Encrypted, 0, EncryptedSigned, 0, Encrypted.Length);

            return Encrypted;
        }

        private static RSACryptoServiceProvider GetRSA(sbyte[] Key)
        {
            RSACryptoServiceProvider RSA = DecodeX509PublicKey(Convert.FromBase64String(_RSAPublicKey));

            byte[] KeyUnSigned = new byte[Key.Length];
            Buffer.BlockCopy(Key, 0, KeyUnSigned, 0, Key.Length);

            byte[] DecryptedData = PublicDecrypt(KeyUnSigned, RSA.ExportParameters(false));

            RSACryptoServiceProvider NewRSA = DecodeX509PublicKey(DecryptedData);

            return NewRSA;
        }

        private static string GetSalt(string Salt)
        {
            if (Salt.Length < 32)
            {
                while (Salt.Length < 32)
                {
                    Salt += " ";
                }
            }

            return Salt;
        }

        private static byte[] PublicDecrypt(byte[] Data, RSAParameters RSAParameters)
        {
            BigInteger Exponent = new BigInteger(RSAParameters.Exponent.Reverse().Concat(new byte[] { 0 }).ToArray());
            BigInteger Modulus = new BigInteger(RSAParameters.Modulus.Reverse().Concat(new byte[] { 0 }).ToArray());

            BigInteger PreparedData = new BigInteger(Data   // Our data block
                .Reverse()  // BigInteger has another byte order
                .Concat(new byte[] { 0 })   // Append 0 so we are always handling positive numbers
                .ToArray()  // Constructor wants an array
            );

            byte[] DecryptedData = BigInteger.ModPow(PreparedData, Exponent, Modulus)   // The RSA operation itself
                .ToByteArray()  // Make bytes from BigInteger
                .Reverse()  // Back to "normal" byte order
                .ToArray(); // Return as byte array

            return DecryptedData.SkipWhile(x => x != 0).Skip(1).ToArray(); // PKCS#1 padding
        }

        private static RSACryptoServiceProvider DecodeX509PublicKey(byte[] X509Key)
        {
            // Encoded OID sequence for  PKCS#1 RSAEncryption szOID_RSA_RSA = "1.2.840.113549.1.1.1"
            byte[] SeqOID = { 0x30, 0x0D, 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01, 0x05, 0x00 };
            byte[] Seq = new byte[15];

            // ---------  Set up stream to read the ASN.1 encoded SubjectPublicKeyInfo blob  ------

            MemoryStream MemoryStream = new MemoryStream(X509Key);
            BinaryReader BinaryReader = new BinaryReader(MemoryStream); // Wrap Memory Stream with BinaryReader for easy reading

            byte Byte = 0;
            ushort TwoBytes = 0;

            try
            {
                TwoBytes = BinaryReader.ReadUInt16();

                if (TwoBytes == 0x8130) // Data read as little endian order (actual data order for Sequence is 30 81)
                    BinaryReader.ReadByte();	// Advance 1 byte
                else if (TwoBytes == 0x8230)
                    BinaryReader.ReadInt16();	// Advance 2 bytes
                else
                    return null;

                Seq = BinaryReader.ReadBytes(15);   // Read the Sequence OID

                if (!CompareByteArrays(Seq, SeqOID))    // Make sure Sequence for OID is correct
                    return null;

                TwoBytes = BinaryReader.ReadUInt16();

                if (TwoBytes == 0x8103) // Data read as little endian order (actual data order for Bit String is 03 81)
                    BinaryReader.ReadByte();	// Advance 1 byte
                else if (TwoBytes == 0x8203)
                    BinaryReader.ReadInt16();	// Advance 2 bytes
                else
                    return null;

                Byte = BinaryReader.ReadByte();

                if (Byte != 0x00)   // Expect null byte next
                    return null;

                TwoBytes = BinaryReader.ReadUInt16();

                if (TwoBytes == 0x8130) // Data read as little endian order (actual data order for Sequence is 30 81)
                    BinaryReader.ReadByte();	// Advance 1 byte
                else if (TwoBytes == 0x8230)
                    BinaryReader.ReadInt16();   // Advance 2 bytes
                else
                    return null;

                TwoBytes = BinaryReader.ReadUInt16();

                byte LowByte = 0x00;
                byte HighByte = 0x00;

                if (TwoBytes == 0x8102) // Data read as little endian order (actual data order for Integer is 02 81)
                {
                    LowByte = BinaryReader.ReadByte();  // Read next bytes which is bytes in modulus
                }
                else if (TwoBytes == 0x8202)
                {
                    HighByte = BinaryReader.ReadByte(); // Advance 2 bytes
                    LowByte = BinaryReader.ReadByte();
                }
                else
                {
                    return null;
                }

                byte[] ModInt = { LowByte, HighByte, 0x00, 0x00 };  // Reverse byte order since ASN.1 key uses big endian order
                int ModSize = BitConverter.ToInt32(ModInt, 0);

                byte FirstByte = BinaryReader.ReadByte();
                BinaryReader.BaseStream.Seek(-1, SeekOrigin.Current);

                if (FirstByte == 0x00)  // If first byte (highest order) of modulus is zero, don't include it
                {
                    BinaryReader.ReadByte();    // Skip this null byte
                    ModSize -= 1;   // Reduce modulus buffer size by 1
                }

                byte[] Modulus = BinaryReader.ReadBytes(ModSize);   // Read the modulus bytes

                if (BinaryReader.ReadByte() != 0x02)    // Expect an Integer for the exponent data
                    return null;

                int ExponentBytes = (int)BinaryReader.ReadByte();   // Should only need one byte for actual exponent data (for all useful values)
                byte[] Exponent = BinaryReader.ReadBytes(ExponentBytes);

                // ------- Create RSACryptoServiceProvider instance and initialize with public key -----

                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSAParameters RSAKeyInfo = new RSAParameters()
                {
                    Modulus = Modulus,
                    Exponent = Exponent
                };

                RSA.ImportParameters(RSAKeyInfo);

                return RSA;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                BinaryReader.Close();
            }
        }

        private static bool CompareByteArrays(byte[] FirstArray, byte[] SecondArray)
        {
            if (FirstArray.Length != SecondArray.Length)
                return false;

            int i = 0;
            foreach (byte Byte in FirstArray)
            {
                if (Byte != SecondArray[i])
                    return false;

                i++;
            }

            return true;
        }
    }
}
