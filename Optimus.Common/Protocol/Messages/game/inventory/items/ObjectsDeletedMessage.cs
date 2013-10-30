


















// Generated on 10/27/2013 07:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ObjectsDeletedMessage : NetworkMessage
{

public const uint Id = 6034;
public override uint MessageId
{
    get { return Id; }
}

public int[] objectUID;
        

public ObjectsDeletedMessage()
{
}

public ObjectsDeletedMessage(int[] objectUID)
        {
            this.objectUID = objectUID;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)objectUID.Length);
            foreach (var entry in objectUID)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            objectUID = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectUID[i] = reader.ReadInt();
            }
            

}


}


}