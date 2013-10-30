


















// Generated on 10/27/2013 07:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ObjectMovementMessage : NetworkMessage
{

public const uint Id = 3010;
public override uint MessageId
{
    get { return Id; }
}

public int objectUID;
        public byte position;
        

public ObjectMovementMessage()
{
}

public ObjectMovementMessage(int objectUID, byte position)
        {
            this.objectUID = objectUID;
            this.position = position;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(objectUID);
            writer.WriteByte(position);
            

}

public override void Deserialize(BigEndianReader reader)
{

objectUID = reader.ReadInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            position = reader.ReadByte();
            if (position < 0 || position > 255)
                throw new Exception("Forbidden value on position = " + position + ", it doesn't respect the following condition : position < 0 || position > 255");
            

}


}


}