


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ObjectEffectCreature : ObjectEffect
{

public const short Id = 71;
public override short TypeId
{
    get { return Id; }
}

public short monsterFamilyId;
        

public ObjectEffectCreature()
{
}

public ObjectEffectCreature(short actionId, short monsterFamilyId)
         : base(actionId)
        {
            this.monsterFamilyId = monsterFamilyId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(monsterFamilyId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            monsterFamilyId = reader.ReadShort();
            if (monsterFamilyId < 0)
                throw new Exception("Forbidden value on monsterFamilyId = " + monsterFamilyId + ", it doesn't respect the following condition : monsterFamilyId < 0");
            

}


}


}