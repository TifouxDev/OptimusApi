


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class CharacterMinimalPlusLookInformations : CharacterMinimalInformations
{

public const short Id = 163;
public override short TypeId
{
    get { return Id; }
}

public Types.EntityLook entityLook;
        

public CharacterMinimalPlusLookInformations()
{
}

public CharacterMinimalPlusLookInformations(int id, byte level, string name, Types.EntityLook entityLook)
         : base(id, level, name)
        {
            this.entityLook = entityLook;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            entityLook.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
            

}


}


}