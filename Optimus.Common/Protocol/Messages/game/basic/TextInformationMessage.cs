


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TextInformationMessage : NetworkMessage
{

public const uint Id = 780;
public override uint MessageId
{
    get { return Id; }
}

public sbyte msgType;
        public short msgId;
        public string[] parameters;
        

public TextInformationMessage()
{
}

public TextInformationMessage(sbyte msgType, short msgId, string[] parameters)
        {
            this.msgType = msgType;
            this.msgId = msgId;
            this.parameters = parameters;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(msgType);
            writer.WriteShort(msgId);
            writer.WriteUShort((ushort)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

msgType = reader.ReadSByte();
            if (msgType < 0)
                throw new Exception("Forbidden value on msgType = " + msgType + ", it doesn't respect the following condition : msgType < 0");
            msgId = reader.ReadShort();
            if (msgId < 0)
                throw new Exception("Forbidden value on msgId = " + msgId + ", it doesn't respect the following condition : msgId < 0");
            var limit = reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
            

}


}


}