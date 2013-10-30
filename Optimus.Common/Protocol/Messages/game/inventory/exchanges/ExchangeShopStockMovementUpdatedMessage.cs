


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeShopStockMovementUpdatedMessage : NetworkMessage
{

public const uint Id = 5909;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemToSell objectInfo;
        

public ExchangeShopStockMovementUpdatedMessage()
{
}

public ExchangeShopStockMovementUpdatedMessage(Types.ObjectItemToSell objectInfo)
        {
            this.objectInfo = objectInfo;
        }
        

public override void Serialize(BigEndianWriter writer)
{

objectInfo.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

objectInfo = new Types.ObjectItemToSell();
            objectInfo.Deserialize(reader);
            

}


}


}