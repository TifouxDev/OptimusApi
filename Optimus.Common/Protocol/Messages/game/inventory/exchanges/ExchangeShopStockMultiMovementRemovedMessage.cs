


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeShopStockMultiMovementRemovedMessage : NetworkMessage
{

public const uint Id = 6037;
public override uint MessageId
{
    get { return Id; }
}

public int[] objectIdList;
        

public ExchangeShopStockMultiMovementRemovedMessage()
{
}

public ExchangeShopStockMultiMovementRemovedMessage(int[] objectIdList)
        {
            this.objectIdList = objectIdList;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)objectIdList.Length);
            foreach (var entry in objectIdList)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            objectIdList = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectIdList[i] = reader.ReadInt();
            }
            

}


}


}