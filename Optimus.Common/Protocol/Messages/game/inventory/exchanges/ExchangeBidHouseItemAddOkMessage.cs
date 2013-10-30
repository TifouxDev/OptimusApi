


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeBidHouseItemAddOkMessage : NetworkMessage
{

public const uint Id = 5945;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemToSellInBid itemInfo;
        

public ExchangeBidHouseItemAddOkMessage()
{
}

public ExchangeBidHouseItemAddOkMessage(Types.ObjectItemToSellInBid itemInfo)
        {
            this.itemInfo = itemInfo;
        }
        

public override void Serialize(BigEndianWriter writer)
{

itemInfo.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

itemInfo = new Types.ObjectItemToSellInBid();
            itemInfo.Deserialize(reader);
            

}


}


}