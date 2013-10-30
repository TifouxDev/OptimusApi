


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeObjectMovePricedMessage : ExchangeObjectMoveMessage
{

public const uint Id = 5514;
public override uint MessageId
{
    get { return Id; }
}

public int price;
        

public ExchangeObjectMovePricedMessage()
{
}

public ExchangeObjectMovePricedMessage(int objectUID, int quantity, int price)
         : base(objectUID, quantity)
        {
            this.price = price;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(price);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            price = reader.ReadInt();
            

}


}


}