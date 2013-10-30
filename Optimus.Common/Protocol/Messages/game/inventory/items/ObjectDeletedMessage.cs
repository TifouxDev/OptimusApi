


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ObjectDeletedMessage : NetworkMessage
{

public const uint Id = 3024;
public override uint MessageId
{
    get { return Id; }
}

public int objectUID;
        

public ObjectDeletedMessage()
{
}

public ObjectDeletedMessage(int objectUID)
        {
            this.objectUID = objectUID;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(objectUID);
            

}

public override void Deserialize(BigEndianReader reader)
{

objectUID = reader.ReadInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            

}


}


}