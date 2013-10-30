


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class GroupMonsterStaticInformationsWithAlternatives : GroupMonsterStaticInformations
{

public const short Id = 396;
public override short TypeId
{
    get { return Id; }
}

public Types.AlternativeMonstersInGroupLightInformations[] alternatives;
        

public GroupMonsterStaticInformationsWithAlternatives()
{
}

public GroupMonsterStaticInformationsWithAlternatives(Types.MonsterInGroupLightInformations mainCreatureLightInfos, Types.MonsterInGroupInformations[] underlings, Types.AlternativeMonstersInGroupLightInformations[] alternatives)
         : base(mainCreatureLightInfos, underlings)
        {
            this.alternatives = alternatives;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)alternatives.Length);
            foreach (var entry in alternatives)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            alternatives = new Types.AlternativeMonstersInGroupLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alternatives[i] = new Types.AlternativeMonstersInGroupLightInformations();
                 alternatives[i].Deserialize(reader);
            }
            

}


}


}