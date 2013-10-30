


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FightTeamInformations : AbstractFightTeamInformations
{

public const short Id = 33;
public override short TypeId
{
    get { return Id; }
}

public Types.FightTeamMemberInformations[] teamMembers;
        

public FightTeamInformations()
{
}

public FightTeamInformations(sbyte teamId, int leaderId, sbyte teamSide, sbyte teamTypeId, Types.FightTeamMemberInformations[] teamMembers)
         : base(teamId, leaderId, teamSide, teamTypeId)
        {
            this.teamMembers = teamMembers;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)teamMembers.Length);
            foreach (var entry in teamMembers)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            teamMembers = new Types.FightTeamMemberInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 teamMembers[i] = Types.ProtocolTypeManager.GetInstance<Types.FightTeamMemberInformations>(reader.ReadShort());
                 teamMembers[i].Deserialize(reader);
            }
            

}


}


}