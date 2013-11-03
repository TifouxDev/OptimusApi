using Optimus.Common.IO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Tool.D2P.Map
{
    public class Map
    {
        public static string DecryptionKey = "649ae451ca33ec53bbcbcc33becf15f4";


        public Map(FastBigEndianReader reader)
        {
            ReaderMap(reader);
        }

        public byte MapType
        {
            get;
            private set;
        }
        public int Id
        {
            get;
            private set;
        }

        public byte EncryptionVersion
        {
            get;
            private set;
        }

        public uint RelativeId
        {
            get;
            private set;
        }
        public byte Version
        {
            get;
            private set;
        }

        public int SubAreaId
        {
            get;
            private set;
        }
        public bool Encrypted
        {
            get;
            private set;
        }
        public int BottomNeighbourId
        {
            get;
            private set;
        }

        public int LeftNeighbourId
        {
            get;
            private set;
        }

        public int RightNeighbourId
        {
            get;
            private set;
        }

        public int ShadowBonusOnEntities
        {
            get;
            private set;
        }

        public Color BackgroundColor
        {
            get;
            private set;
        }

        public ushort ZoomScale
        {
            get;
            private set;
        }

        public short ZoomOffsetX
        {
            get;
            private set;
        }

        public short ZoomOffsetY
        {
            get;
            private set;
        }

        public bool UseLowPassFilter
        {
            get;
            private set;
        }

        public bool UseReverb
        {
            get;
            private set;
        }

        public int PresetId
        {
            get;
            private set;
        }

        public ReadOnlyCollection<Fixture> BackgroudFixtures
        {
            get;
            private set;
        }

        public int TopNeighbourId
        {
            get;
            private set;
        }

        public ReadOnlyCollection<Fixture> ForegroundFixtures
        {
            get;
            private set;
        }

        public ReadOnlyCollection<CellData> Cells
        {
            get;
            private set;
        }

        public int GroundCRC
        {
            get;
            private set;
        }

        public ReadOnlyCollection<Layer> Layers
        {
            get;
            private set;
        }

        public bool UsingNewMovementSystem
        {
            get;
            private set;
        }

       internal void ReaderMap(FastBigEndianReader reader)
       {
           int header = reader.ReadByte();
           if (header != 77)
           {
               try
               {
                   reader.Seek(0, SeekOrigin.Begin);
                   var output = new MemoryStream();
                   ZipHelper.Deflate(new MemoryStream(reader.ReadBytes((int)reader.BytesAvailable)), output);

                   var uncompress = output.ToArray();

                   reader.Dispose();
                   reader = new FastBigEndianReader(uncompress);

                   header = reader.ReadByte();

                   if (header != 77)
                       throw new FileLoadException("Wrong header file");

               }
               catch (Exception ex)
               {
                   throw new FileLoadException("Wrong header file");
               }
           }

           this.Version = reader.ReadByte();
           this.Id = reader.ReadInt();
           if (Version >= 7)
           {
               this.Encrypted = reader.ReadBoolean();
               this.EncryptionVersion = reader.ReadByte();
               int DataLen = reader.ReadInt();
               byte[] decryptionKey = Encoding.Default.GetBytes(Map.DecryptionKey); 
               if (this.Encrypted)  
               { 
                   byte[] encryptedData = reader.ReadBytes(DataLen);
                   for(int i =0; i < encryptedData.Length;i++)
                   {
                       encryptedData[i] = (byte)(encryptedData[i] ^ decryptionKey[i % decryptionKey.Length]);  
                   }
                   reader = new FastBigEndianReader(encryptedData);      
               }    
           }
           this.RelativeId = (uint)reader.ReadInt();
           this.MapType = reader.ReadByte();
           this.SubAreaId = reader.ReadInt();
           this.TopNeighbourId = reader.ReadInt();
           this.BottomNeighbourId = reader.ReadInt();
           this.LeftNeighbourId = reader.ReadInt();
           this.RightNeighbourId = reader.ReadInt();
           this.ShadowBonusOnEntities = reader.ReadInt();

           if (this.Version >= 3)
           {
               this.BackgroundColor = Color.FromArgb(reader.ReadByte(), reader.ReadByte(), reader.ReadByte());
           }

           if (this.Version >= 4)
           {
               ZoomScale = reader.ReadUShort();
               ZoomOffsetX = reader.ReadShort();
               ZoomOffsetY = reader.ReadShort();
           }
           this.UseLowPassFilter = reader.ReadByte() == 1;
           this.UseReverb = reader.ReadByte() == 1;
           if (UseReverb)
           {
               PresetId = reader.ReadInt();
           }
           {
               PresetId = -1;
           }

           int backGroundsCount = reader.ReadByte();
           List<Fixture> backgroundFixtures = new List<Fixture>();
           for (int i = 0; i < backGroundsCount; i++)
           {
               backgroundFixtures.Add(new Fixture(this, reader));
           }
           this.BackgroudFixtures = backgroundFixtures.AsReadOnly();

   
           int foregroundsCount = reader.ReadByte();
           List<Fixture> foregroundFixtures = new List<Fixture>();
           for (int i = 0; i < foregroundsCount; i++) 
           {
               foregroundFixtures.Add(new Fixture(this, reader));
           }
           ForegroundFixtures = foregroundFixtures.AsReadOnly();
            
           int cellCount = 560;
           reader.ReadInt();
           this.GroundCRC = reader.ReadInt();

           int layerCount = reader.ReadByte();
           List<Layer> layers = new List<Layer>();
           for (int i = 0; i < layerCount; i++)
           {
               layers.Add(new Layer(this, reader));
           }
           this.Layers = layers.AsReadOnly();

           List<CellData> cells = new List<CellData>();
           for (int i = 0; i < cellCount; i++)
           {
               cells.Add(new CellData(this, reader)); 
           }
           this.Cells = cells.AsReadOnly();
       }
    }
}
