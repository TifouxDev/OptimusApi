


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeStartOkHumanVendorMessage : NetworkMessage
{

public const uint Id = 5767;
public override uint MessageId
{
    get { return Id; }
}

public int sellerId;
        public Types.ObjectItemToSellInHumanVendorShop[] objectsInfos;
        

public ExchangeStartOkHumanVendorMessage()
{
}

public ExchangeStartOkHumanVendorMessage(int sellerId, Types.ObjectItemToSellInHumanVendorShop[] objectsInfos)
        {
            this.sellerId = sellerId;
            this.objectsInfos = objectsInfos;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(sellerId);
            writer.WriteUShort((ushort)objectsInfos.Length);
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

sellerId = reader.ReadInt();
            if (sellerId < 0)
                throw new Exception("Forbidden value on sellerId = " + sellerId + ", it doesn't respect the following condition : sellerId < 0");
            var limit = reader.ReadUShort();
            objectsInfos = new Types.ObjectItemToSellInHumanVendorShop[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsInfos[i] = new Types.ObjectItemToSellInHumanVendorShop();
                 objectsInfos[i].Deserialize(reader);
            }
            

}


}


}