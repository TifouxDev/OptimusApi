


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FightAllianceTeamInformations : FightTeamInformations
{

public const short Id = 439;
public override short TypeId
{
    get { return Id; }
}

public sbyte relation;
        

public FightAllianceTeamInformations()
{
}

public FightAllianceTeamInformations(sbyte teamId, int leaderId, sbyte teamSide, sbyte teamTypeId, Types.FightTeamMemberInformations[] teamMembers, sbyte relation)
         : base(teamId, leaderId, teamSide, teamTypeId, teamMembers)
        {
            this.relation = relation;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(relation);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            relation = reader.ReadSByte();
            if (relation < 0)
                throw new Exception("Forbidden value on relation = " + relation + ", it doesn't respect the following condition : relation < 0");
            

}


}


}