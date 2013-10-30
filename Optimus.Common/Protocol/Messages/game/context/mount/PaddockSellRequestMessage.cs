


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PaddockSellRequestMessage : NetworkMessage
{

public const uint Id = 5953;
public override uint MessageId
{
    get { return Id; }
}

public int price;
        

public PaddockSellRequestMessage()
{
}

public PaddockSellRequestMessage(int price)
        {
            this.price = price;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(price);
            

}

public override void Deserialize(BigEndianReader reader)
{

price = reader.ReadInt();
            if (price < 0)
                throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            

}


}


}