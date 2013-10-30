


















// Generated on 10/27/2013 07:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class AchievementRewardable
{

public const short Id = 412;
public virtual short TypeId
{
    get { return Id; }
}

public short id;
        public short finishedlevel;
        

public AchievementRewardable()
{
}

public AchievementRewardable(short id, short finishedlevel)
        {
            this.id = id;
            this.finishedlevel = finishedlevel;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteShort(id);
            writer.WriteShort(finishedlevel);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

id = reader.ReadShort();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            finishedlevel = reader.ReadShort();
            if (finishedlevel < 0 || finishedlevel > 200)
                throw new Exception("Forbidden value on finishedlevel = " + finishedlevel + ", it doesn't respect the following condition : finishedlevel < 0 || finishedlevel > 200");
            

}


}


}