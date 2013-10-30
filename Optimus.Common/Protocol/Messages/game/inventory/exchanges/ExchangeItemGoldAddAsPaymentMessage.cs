


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeItemGoldAddAsPaymentMessage : NetworkMessage
{

public const uint Id = 5770;
public override uint MessageId
{
    get { return Id; }
}

public sbyte paymentType;
        public int quantity;
        

public ExchangeItemGoldAddAsPaymentMessage()
{
}

public ExchangeItemGoldAddAsPaymentMessage(sbyte paymentType, int quantity)
        {
            this.paymentType = paymentType;
            this.quantity = quantity;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(paymentType);
            writer.WriteInt(quantity);
            

}

public override void Deserialize(BigEndianReader reader)
{

paymentType = reader.ReadSByte();
            quantity = reader.ReadInt();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}