


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightUpdateTeamMessage : NetworkMessage
{

public const uint Id = 5572;
public override uint MessageId
{
    get { return Id; }
}

public short fightId;
        public Types.FightTeamInformations team;
        

public GameFightUpdateTeamMessage()
{
}

public GameFightUpdateTeamMessage(short fightId, Types.FightTeamInformations team)
        {
            this.fightId = fightId;
            this.team = team;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(fightId);
            team.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

fightId = reader.ReadShort();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            team = new Types.FightTeamInformations();
            team.Deserialize(reader);
            

}


}


}