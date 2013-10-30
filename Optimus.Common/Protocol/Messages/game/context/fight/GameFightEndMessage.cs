


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightEndMessage : NetworkMessage
{

public const uint Id = 720;
public override uint MessageId
{
    get { return Id; }
}

public int duration;
        public short ageBonus;
        public short lootShareLimitMalus;
        public Types.FightResultListEntry[] results;
        

public GameFightEndMessage()
{
}

public GameFightEndMessage(int duration, short ageBonus, short lootShareLimitMalus, Types.FightResultListEntry[] results)
        {
            this.duration = duration;
            this.ageBonus = ageBonus;
            this.lootShareLimitMalus = lootShareLimitMalus;
            this.results = results;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(duration);
            writer.WriteShort(ageBonus);
            writer.WriteShort(lootShareLimitMalus);
            writer.WriteUShort((ushort)results.Length);
            foreach (var entry in results)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

duration = reader.ReadInt();
            if (duration < 0)
                throw new Exception("Forbidden value on duration = " + duration + ", it doesn't respect the following condition : duration < 0");
            ageBonus = reader.ReadShort();
            lootShareLimitMalus = reader.ReadShort();
            var limit = reader.ReadUShort();
            results = new Types.FightResultListEntry[limit];
            for (int i = 0; i < limit; i++)
            {
                 results[i] = Types.ProtocolTypeManager.GetInstance<Types.FightResultListEntry>(reader.ReadShort());
                 results[i].Deserialize(reader);
            }
            

}


}


}