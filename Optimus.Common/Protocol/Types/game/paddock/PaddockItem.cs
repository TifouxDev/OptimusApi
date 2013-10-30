


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class PaddockItem : ObjectItemInRolePlay
{

public const short Id = 185;
public override short TypeId
{
    get { return Id; }
}

public Types.ItemDurability durability;
        

public PaddockItem()
{
}

public PaddockItem(short cellId, short objectGID, Types.ItemDurability durability)
         : base(cellId, objectGID)
        {
            this.durability = durability;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            durability.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            durability = new Types.ItemDurability();
            durability.Deserialize(reader);
            

}


}


}