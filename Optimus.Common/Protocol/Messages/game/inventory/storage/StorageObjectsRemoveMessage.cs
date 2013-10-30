


















// Generated on 10/27/2013 07:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class StorageObjectsRemoveMessage : NetworkMessage
{

public const uint Id = 6035;
public override uint MessageId
{
    get { return Id; }
}

public int[] objectUIDList;
        

public StorageObjectsRemoveMessage()
{
}

public StorageObjectsRemoveMessage(int[] objectUIDList)
        {
            this.objectUIDList = objectUIDList;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)objectUIDList.Length);
            foreach (var entry in objectUIDList)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            objectUIDList = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectUIDList[i] = reader.ReadInt();
            }
            

}


}


}