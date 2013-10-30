


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class SkillActionDescription
{

public const short Id = 102;
public virtual short TypeId
{
    get { return Id; }
}

public short skillId;
        

public SkillActionDescription()
{
}

public SkillActionDescription(short skillId)
        {
            this.skillId = skillId;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteShort(skillId);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

skillId = reader.ReadShort();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            

}


}


}