


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class InteractiveElementSkill
{

public const short Id = 219;
public virtual short TypeId
{
    get { return Id; }
}

public int skillId;
        public int skillInstanceUid;
        

public InteractiveElementSkill()
{
}

public InteractiveElementSkill(int skillId, int skillInstanceUid)
        {
            this.skillId = skillId;
            this.skillInstanceUid = skillInstanceUid;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteInt(skillId);
            writer.WriteInt(skillInstanceUid);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

skillId = reader.ReadInt();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            skillInstanceUid = reader.ReadInt();
            if (skillInstanceUid < 0)
                throw new Exception("Forbidden value on skillInstanceUid = " + skillInstanceUid + ", it doesn't respect the following condition : skillInstanceUid < 0");
            

}


}


}