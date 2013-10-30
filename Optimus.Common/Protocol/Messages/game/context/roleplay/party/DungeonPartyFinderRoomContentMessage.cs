


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class DungeonPartyFinderRoomContentMessage : NetworkMessage
{

public const uint Id = 6247;
public override uint MessageId
{
    get { return Id; }
}

public short dungeonId;
        public Types.DungeonPartyFinderPlayer[] players;
        

public DungeonPartyFinderRoomContentMessage()
{
}

public DungeonPartyFinderRoomContentMessage(short dungeonId, Types.DungeonPartyFinderPlayer[] players)
        {
            this.dungeonId = dungeonId;
            this.players = players;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(dungeonId);
            writer.WriteUShort((ushort)players.Length);
            foreach (var entry in players)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

dungeonId = reader.ReadShort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            var limit = reader.ReadUShort();
            players = new Types.DungeonPartyFinderPlayer[limit];
            for (int i = 0; i < limit; i++)
            {
                 players[i] = new Types.DungeonPartyFinderPlayer();
                 players[i].Deserialize(reader);
            }
            

}


}


}