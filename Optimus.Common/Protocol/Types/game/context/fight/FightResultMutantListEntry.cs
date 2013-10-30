


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FightResultMutantListEntry : FightResultFighterListEntry
{

public const short Id = 216;
public override short TypeId
{
    get { return Id; }
}

public ushort level;
        

public FightResultMutantListEntry()
{
}

public FightResultMutantListEntry(short outcome, Types.FightLoot rewards, int id, bool alive, ushort level)
         : base(outcome, rewards, id, alive)
        {
            this.level = level;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort(level);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            level = reader.ReadUShort();
            if (level < 0 || level > 65535)
                throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 0 || level > 65535");
            

}


}


}