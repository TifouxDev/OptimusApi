


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameRolePlayArenaFightPropositionMessage : NetworkMessage
{

public const uint Id = 6276;
public override uint MessageId
{
    get { return Id; }
}

public int fightId;
        public int[] alliesId;
        public short duration;
        

public GameRolePlayArenaFightPropositionMessage()
{
}

public GameRolePlayArenaFightPropositionMessage(int fightId, int[] alliesId, short duration)
        {
            this.fightId = fightId;
            this.alliesId = alliesId;
            this.duration = duration;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteUShort((ushort)alliesId.Length);
            foreach (var entry in alliesId)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteShort(duration);
            

}

public override void Deserialize(BigEndianReader reader)
{

fightId = reader.ReadInt();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            var limit = reader.ReadUShort();
            alliesId = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliesId[i] = reader.ReadInt();
            }
            duration = reader.ReadShort();
            if (duration < 0)
                throw new Exception("Forbidden value on duration = " + duration + ", it doesn't respect the following condition : duration < 0");
            

}


}


}