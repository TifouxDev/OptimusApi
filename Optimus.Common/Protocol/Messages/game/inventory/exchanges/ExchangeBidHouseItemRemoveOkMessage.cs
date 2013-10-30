


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeBidHouseItemRemoveOkMessage : NetworkMessage
{

public const uint Id = 5946;
public override uint MessageId
{
    get { return Id; }
}

public int sellerId;
        

public ExchangeBidHouseItemRemoveOkMessage()
{
}

public ExchangeBidHouseItemRemoveOkMessage(int sellerId)
        {
            this.sellerId = sellerId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(sellerId);
            

}

public override void Deserialize(BigEndianReader reader)
{

sellerId = reader.ReadInt();
            

}


}


}