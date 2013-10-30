


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeStartedMountStockMessage : NetworkMessage
{

public const uint Id = 5984;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objectsInfos;
        

public ExchangeStartedMountStockMessage()
{
}

public ExchangeStartedMountStockMessage(Types.ObjectItem[] objectsInfos)
        {
            this.objectsInfos = objectsInfos;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)objectsInfos.Length);
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            objectsInfos = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsInfos[i] = new Types.ObjectItem();
                 objectsInfos[i].Deserialize(reader);
            }
            

}


}


}