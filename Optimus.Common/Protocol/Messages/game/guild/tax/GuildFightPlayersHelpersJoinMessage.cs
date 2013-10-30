


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildFightPlayersHelpersJoinMessage : NetworkMessage
{

public const uint Id = 5720;
public override uint MessageId
{
    get { return Id; }
}

public double fightId;
        public Types.CharacterMinimalPlusLookInformations playerInfo;
        

public GuildFightPlayersHelpersJoinMessage()
{
}

public GuildFightPlayersHelpersJoinMessage(double fightId, Types.CharacterMinimalPlusLookInformations playerInfo)
        {
            this.fightId = fightId;
            this.playerInfo = playerInfo;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteDouble(fightId);
            playerInfo.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

fightId = reader.ReadDouble();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            playerInfo = new Types.CharacterMinimalPlusLookInformations();
            playerInfo.Deserialize(reader);
            

}


}


}