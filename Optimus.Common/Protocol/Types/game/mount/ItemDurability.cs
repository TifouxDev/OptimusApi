


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ItemDurability
{

public const short Id = 168;
public virtual short TypeId
{
    get { return Id; }
}

public short durability;
        public short durabilityMax;
        

public ItemDurability()
{
}

public ItemDurability(short durability, short durabilityMax)
        {
            this.durability = durability;
            this.durabilityMax = durabilityMax;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteShort(durability);
            writer.WriteShort(durabilityMax);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

durability = reader.ReadShort();
            durabilityMax = reader.ReadShort();
            

}


}


}