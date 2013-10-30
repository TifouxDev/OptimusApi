


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeBidHouseInListRemovedMessage : NetworkMessage
{

public const uint Id = 5950;
public override uint MessageId
{
    get { return Id; }
}

public int itemUID;
        

public ExchangeBidHouseInListRemovedMessage()
{
}

public ExchangeBidHouseInListRemovedMessage(int itemUID)
        {
            this.itemUID = itemUID;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(itemUID);
            

}

public override void Deserialize(BigEndianReader reader)
{

itemUID = reader.ReadInt();
            

}


}


}