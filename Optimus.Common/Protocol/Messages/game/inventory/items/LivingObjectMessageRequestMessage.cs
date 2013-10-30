


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class LivingObjectMessageRequestMessage : NetworkMessage
{

public const uint Id = 6066;
public override uint MessageId
{
    get { return Id; }
}

public short msgId;
        public string[] parameters;
        public uint livingObject;
        

public LivingObjectMessageRequestMessage()
{
}

public LivingObjectMessageRequestMessage(short msgId, string[] parameters, uint livingObject)
        {
            this.msgId = msgId;
            this.parameters = parameters;
            this.livingObject = livingObject;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(msgId);
            writer.WriteUShort((ushort)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteUInt(livingObject);
            

}

public override void Deserialize(BigEndianReader reader)
{

msgId = reader.ReadShort();
            if (msgId < 0)
                throw new Exception("Forbidden value on msgId = " + msgId + ", it doesn't respect the following condition : msgId < 0");
            var limit = reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
            livingObject = reader.ReadUInt();
            if (livingObject < 0 || livingObject > 4.294967295E9)
                throw new Exception("Forbidden value on livingObject = " + livingObject + ", it doesn't respect the following condition : livingObject < 0 || livingObject > 4.294967295E9");
            

}


}


}