


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class TaxCollectorLootInformations : TaxCollectorComplementaryInformations
{

public const short Id = 372;
public override short TypeId
{
    get { return Id; }
}

public int kamas;
        public double experience;
        public int pods;
        public int itemsValue;
        

public TaxCollectorLootInformations()
{
}

public TaxCollectorLootInformations(int kamas, double experience, int pods, int itemsValue)
        {
            this.kamas = kamas;
            this.experience = experience;
            this.pods = pods;
            this.itemsValue = itemsValue;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(kamas);
            writer.WriteDouble(experience);
            writer.WriteInt(pods);
            writer.WriteInt(itemsValue);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            kamas = reader.ReadInt();
            if (kamas < 0)
                throw new Exception("Forbidden value on kamas = " + kamas + ", it doesn't respect the following condition : kamas < 0");
            experience = reader.ReadDouble();
            if (experience < 0)
                throw new Exception("Forbidden value on experience = " + experience + ", it doesn't respect the following condition : experience < 0");
            pods = reader.ReadInt();
            if (pods < 0)
                throw new Exception("Forbidden value on pods = " + pods + ", it doesn't respect the following condition : pods < 0");
            itemsValue = reader.ReadInt();
            if (itemsValue < 0)
                throw new Exception("Forbidden value on itemsValue = " + itemsValue + ", it doesn't respect the following condition : itemsValue < 0");
            

}


}


}