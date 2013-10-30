


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeClearPaymentForCraftMessage : NetworkMessage
{

public const uint Id = 6145;
public override uint MessageId
{
    get { return Id; }
}

public sbyte paymentType;
        

public ExchangeClearPaymentForCraftMessage()
{
}

public ExchangeClearPaymentForCraftMessage(sbyte paymentType)
        {
            this.paymentType = paymentType;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(paymentType);
            

}

public override void Deserialize(BigEndianReader reader)
{

paymentType = reader.ReadSByte();
            

}


}


}