


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeBidPriceForSellerMessage : ExchangeBidPriceMessage
{

public const uint Id = 6464;
public override uint MessageId
{
    get { return Id; }
}

public bool allIdentical;
        public int[] minimalPrices;
        

public ExchangeBidPriceForSellerMessage()
{
}

public ExchangeBidPriceForSellerMessage(int genericId, int averagePrice, bool allIdentical, int[] minimalPrices)
         : base(genericId, averagePrice)
        {
            this.allIdentical = allIdentical;
            this.minimalPrices = minimalPrices;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(allIdentical);
            writer.WriteUShort((ushort)minimalPrices.Length);
            foreach (var entry in minimalPrices)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            allIdentical = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            minimalPrices = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 minimalPrices[i] = reader.ReadInt();
            }
            

}


}


}