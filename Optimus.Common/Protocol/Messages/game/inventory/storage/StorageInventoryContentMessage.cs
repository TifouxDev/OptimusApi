


















// Generated on 10/27/2013 07:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class StorageInventoryContentMessage : InventoryContentMessage
{

public const uint Id = 5646;
public override uint MessageId
{
    get { return Id; }
}



public StorageInventoryContentMessage()
{
}

public StorageInventoryContentMessage(Types.ObjectItem[] objects, int kamas)
         : base(objects, kamas)
        {
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            

}


}


}