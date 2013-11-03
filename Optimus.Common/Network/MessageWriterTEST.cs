using Optimus.Common.IO;
using Optimus.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimus.Common.Network
{
    public class MessageWriterTEST
    {
        public void BuildPacket(BigEndianWriter writer, int MessageId )
        {
            byte[] data = writer.Data;

            writer.Clear();

            int messageLenghtType = ComputeTypeLen(data.Length);
            short header = ComputeStaticHeader((int)MessageId, messageLenghtType);

            writer.WriteShort(header);

            switch (messageLenghtType)
            {
                case 1:
                    writer.WriteByte((byte)data.Length);
                    break;
                case 2:
                    writer.WriteShort((short)data.Length);
                    break;
                case 3:
                    writer.WriteByte((byte)(data.Length >> 16 & 255));
                    writer.WriteShort((short)(data.Length & 65535));
                    break;
            }

            writer.WriteBytes(data);
        }

        public byte[] BuildPacket(uint id, byte[] data)
        {
            UnknowMessage message = new UnknowMessage(id);
            using (BigEndianWriter writer = new BigEndianWriter(data))
            {
                MessageWriterTEST t = new MessageWriterTEST();
                t.BuildPacket(writer,(int)id);
               // message.BuildPacket(writer);
                return writer.Data;
            }
        }

        private short ComputeStaticHeader(int packetId, int messageLenghtType)
        {
            return (short)((packetId << 2) | messageLenghtType);
        }

        private short ComputeTypeLen(int messageLenght)
        {
            if (messageLenght > ushort.MaxValue) return 3;
            if (messageLenght > byte.MaxValue) return 2;
            if (messageLenght > 0) return 1;
            return 0;
        }
    }
}
