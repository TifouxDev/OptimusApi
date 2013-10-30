


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeBidPriceMessage : NetworkMessage
{

public const uint Id = 5755;
public override uint MessageId
{
    get { return Id; }
}

public int genericId;
        public int averagePrice;
        

public ExchangeBidPriceMessage()
{
}

public ExchangeBidPriceMessage(int genericId, int averagePrice)
        {
            this.genericId = genericId;
            this.averagePrice = averagePrice;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(genericId);
            writer.WriteInt(averagePrice);
            

}

public override void Deserialize(BigEndianReader reader)
{

genericId = reader.ReadInt();
            if (genericId < 0)
                throw new Exception("Forbidden value on genericId = " + genericId + ", it doesn't respect the following condition : genericId < 0");
            averagePrice = reader.ReadInt();
            

}


}


}