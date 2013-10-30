


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class SkillActionDescriptionTimed : SkillActionDescription
{

public const short Id = 103;
public override short TypeId
{
    get { return Id; }
}

public byte time;
        

public SkillActionDescriptionTimed()
{
}

public SkillActionDescriptionTimed(short skillId, byte time)
         : base(skillId)
        {
            this.time = time;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteByte(time);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            time = reader.ReadByte();
            if (time < 0 || time > 255)
                throw new Exception("Forbidden value on time = " + time + ", it doesn't respect the following condition : time < 0 || time > 255");
            

}


}


}