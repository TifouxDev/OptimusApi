


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FightResultFighterListEntry : FightResultListEntry
{

public const short Id = 189;
public override short TypeId
{
    get { return Id; }
}

public int id;
        public bool alive;
        

public FightResultFighterListEntry()
{
}

public FightResultFighterListEntry(short outcome, Types.FightLoot rewards, int id, bool alive)
         : base(outcome, rewards)
        {
            this.id = id;
            this.alive = alive;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(id);
            writer.WriteBoolean(alive);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            id = reader.ReadInt();
            alive = reader.ReadBoolean();
            

}


}


}