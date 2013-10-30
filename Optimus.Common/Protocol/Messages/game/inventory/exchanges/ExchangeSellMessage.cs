


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeSellMessage : NetworkMessage
{

public const uint Id = 5778;
public override uint MessageId
{
    get { return Id; }
}

public int objectToSellId;
        public int quantity;
        

public ExchangeSellMessage()
{
}

public ExchangeSellMessage(int objectToSellId, int quantity)
        {
            this.objectToSellId = objectToSellId;
            this.quantity = quantity;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(objectToSellId);
            writer.WriteInt(quantity);
            

}

public override void Deserialize(BigEndianReader reader)
{

objectToSellId = reader.ReadInt();
            if (objectToSellId < 0)
                throw new Exception("Forbidden value on objectToSellId = " + objectToSellId + ", it doesn't respect the following condition : objectToSellId < 0");
            quantity = reader.ReadInt();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}