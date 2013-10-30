


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class MonsterInGroupInformations : MonsterInGroupLightInformations
{

public const short Id = 144;
public override short TypeId
{
    get { return Id; }
}

public Types.EntityLook look;
        

public MonsterInGroupInformations()
{
}

public MonsterInGroupInformations(int creatureGenericId, sbyte grade, Types.EntityLook look)
         : base(creatureGenericId, grade)
        {
            this.look = look;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            look.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}