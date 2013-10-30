


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeStartedBidBuyerMessage : NetworkMessage
{

public const uint Id = 5904;
public override uint MessageId
{
    get { return Id; }
}

public Types.SellerBuyerDescriptor buyerDescriptor;
        

public ExchangeStartedBidBuyerMessage()
{
}

public ExchangeStartedBidBuyerMessage(Types.SellerBuyerDescriptor buyerDescriptor)
        {
            this.buyerDescriptor = buyerDescriptor;
        }
        

public override void Serialize(BigEndianWriter writer)
{

buyerDescriptor.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

buyerDescriptor = new Types.SellerBuyerDescriptor();
            buyerDescriptor.Deserialize(reader);
            

}


}


}