


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FightCommonInformations
{

public const short Id = 43;
public virtual short TypeId
{
    get { return Id; }
}

public int fightId;
        public sbyte fightType;
        public Types.FightTeamInformations[] fightTeams;
        public short[] fightTeamsPositions;
        public Types.FightOptionsInformations[] fightTeamsOptions;
        

public FightCommonInformations()
{
}

public FightCommonInformations(int fightId, sbyte fightType, Types.FightTeamInformations[] fightTeams, short[] fightTeamsPositions, Types.FightOptionsInformations[] fightTeamsOptions)
        {
            this.fightId = fightId;
            this.fightType = fightType;
            this.fightTeams = fightTeams;
            this.fightTeamsPositions = fightTeamsPositions;
            this.fightTeamsOptions = fightTeamsOptions;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteSByte(fightType);
            writer.WriteUShort((ushort)fightTeams.Length);
            foreach (var entry in fightTeams)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)fightTeamsPositions.Length);
            foreach (var entry in fightTeamsPositions)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteUShort((ushort)fightTeamsOptions.Length);
            foreach (var entry in fightTeamsOptions)
            {
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(BigEndianReader reader)
{

fightId = reader.ReadInt();
            fightType = reader.ReadSByte();
            if (fightType < 0)
                throw new Exception("Forbidden value on fightType = " + fightType + ", it doesn't respect the following condition : fightType < 0");
            var limit = reader.ReadUShort();
            fightTeams = new Types.FightTeamInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 fightTeams[i] = Types.ProtocolTypeManager.GetInstance<Types.FightTeamInformations>(reader.ReadShort());
                 fightTeams[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            fightTeamsPositions = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 fightTeamsPositions[i] = reader.ReadShort();
            }
            limit = reader.ReadUShort();
            fightTeamsOptions = new Types.FightOptionsInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 fightTeamsOptions[i] = new Types.FightOptionsInformations();
                 fightTeamsOptions[i].Deserialize(reader);
            }
            

}


}


}