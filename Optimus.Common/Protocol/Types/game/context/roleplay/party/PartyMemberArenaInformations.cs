


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class PartyMemberArenaInformations : PartyMemberInformations
{

public const short Id = 391;
public override short TypeId
{
    get { return Id; }
}

public short rank;
        

public PartyMemberArenaInformations()
{
}

public PartyMemberArenaInformations(int id, byte level, string name, Types.EntityLook entityLook, sbyte breed, bool sex, int lifePoints, int maxLifePoints, short prospecting, byte regenRate, short initiative, sbyte alignmentSide, short worldX, short worldY, int mapId, short subAreaId, Types.PlayerStatus status, short rank)
         : base(id, level, name, entityLook, breed, sex, lifePoints, maxLifePoints, prospecting, regenRate, initiative, alignmentSide, worldX, worldY, mapId, subAreaId, status)
        {
            this.rank = rank;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(rank);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            rank = reader.ReadShort();
            if (rank < 0 || rank > 2300)
                throw new Exception("Forbidden value on rank = " + rank + ", it doesn't respect the following condition : rank < 0 || rank > 2300");
            

}


}


}