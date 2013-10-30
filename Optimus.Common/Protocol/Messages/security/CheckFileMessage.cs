


















// Generated on 10/27/2013 07:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CheckFileMessage : NetworkMessage
{

public const uint Id = 6156;
public override uint MessageId
{
    get { return Id; }
}

public string filenameHash;
        public sbyte type;
        public string value;
        

public CheckFileMessage()
{
}

public CheckFileMessage(string filenameHash, sbyte type, string value)
        {
            this.filenameHash = filenameHash;
            this.type = type;
            this.value = value;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(filenameHash);
            writer.WriteSByte(type);
            writer.WriteUTF(value);
            

}

public override void Deserialize(BigEndianReader reader)
{

filenameHash = reader.ReadUTF();
            type = reader.ReadSByte();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            value = reader.ReadUTF();
            

}


}


}