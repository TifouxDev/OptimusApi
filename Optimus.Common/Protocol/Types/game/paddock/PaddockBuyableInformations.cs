


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class PaddockBuyableInformations : PaddockInformations
{

public const short Id = 130;
public override short TypeId
{
    get { return Id; }
}

public int price;
        public bool locked;
        

public PaddockBuyableInformations()
{
}

public PaddockBuyableInformations(short maxOutdoorMount, short maxItems, int price, bool locked)
         : base(maxOutdoorMount, maxItems)
        {
            this.price = price;
            this.locked = locked;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(price);
            writer.WriteBoolean(locked);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            price = reader.ReadInt();
            if (price < 0)
                throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            locked = reader.ReadBoolean();
            

}


}


}