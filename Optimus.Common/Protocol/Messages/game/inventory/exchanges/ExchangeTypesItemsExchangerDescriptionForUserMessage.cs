


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeTypesItemsExchangerDescriptionForUserMessage : NetworkMessage
{

public const uint Id = 5752;
public override uint MessageId
{
    get { return Id; }
}

public Types.BidExchangerObjectInfo[] itemTypeDescriptions;
        

public ExchangeTypesItemsExchangerDescriptionForUserMessage()
{
}

public ExchangeTypesItemsExchangerDescriptionForUserMessage(Types.BidExchangerObjectInfo[] itemTypeDescriptions)
        {
            this.itemTypeDescriptions = itemTypeDescriptions;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)itemTypeDescriptions.Length);
            foreach (var entry in itemTypeDescriptions)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            itemTypeDescriptions = new Types.BidExchangerObjectInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 itemTypeDescriptions[i] = new Types.BidExchangerObjectInfo();
                 itemTypeDescriptions[i].Deserialize(reader);
            }
            

}


}


}