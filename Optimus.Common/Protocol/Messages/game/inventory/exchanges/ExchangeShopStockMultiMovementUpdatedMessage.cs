


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeShopStockMultiMovementUpdatedMessage : NetworkMessage
{

public const uint Id = 6038;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemToSell[] objectInfoList;
        

public ExchangeShopStockMultiMovementUpdatedMessage()
{
}

public ExchangeShopStockMultiMovementUpdatedMessage(Types.ObjectItemToSell[] objectInfoList)
        {
            this.objectInfoList = objectInfoList;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)objectInfoList.Length);
            foreach (var entry in objectInfoList)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            objectInfoList = new Types.ObjectItemToSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectInfoList[i] = new Types.ObjectItemToSell();
                 objectInfoList[i].Deserialize(reader);
            }
            

}


}


}