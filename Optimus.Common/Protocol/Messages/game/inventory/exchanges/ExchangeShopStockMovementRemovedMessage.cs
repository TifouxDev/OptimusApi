


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeShopStockMovementRemovedMessage : NetworkMessage
{

public const uint Id = 5907;
public override uint MessageId
{
    get { return Id; }
}

public int objectId;
        

public ExchangeShopStockMovementRemovedMessage()
{
}

public ExchangeShopStockMovementRemovedMessage(int objectId)
        {
            this.objectId = objectId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(objectId);
            

}

public override void Deserialize(BigEndianReader reader)
{

objectId = reader.ReadInt();
            if (objectId < 0)
                throw new Exception("Forbidden value on objectId = " + objectId + ", it doesn't respect the following condition : objectId < 0");
            

}


}


}