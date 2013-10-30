


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FightResultListEntry
{

public const short Id = 16;
public virtual short TypeId
{
    get { return Id; }
}

public short outcome;
        public Types.FightLoot rewards;
        

public FightResultListEntry()
{
}

public FightResultListEntry(short outcome, Types.FightLoot rewards)
        {
            this.outcome = outcome;
            this.rewards = rewards;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteShort(outcome);
            rewards.Serialize(writer);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

outcome = reader.ReadShort();
            if (outcome < 0)
                throw new Exception("Forbidden value on outcome = " + outcome + ", it doesn't respect the following condition : outcome < 0");
            rewards = new Types.FightLoot();
            rewards.Deserialize(reader);
            

}


}


}