


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class InteractiveElementNamedSkill : InteractiveElementSkill
{

public const short Id = 220;
public override short TypeId
{
    get { return Id; }
}

public int nameId;
        

public InteractiveElementNamedSkill()
{
}

public InteractiveElementNamedSkill(int skillId, int skillInstanceUid, int nameId)
         : base(skillId, skillInstanceUid)
        {
            this.nameId = nameId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(nameId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            nameId = reader.ReadInt();
            if (nameId < 0)
                throw new Exception("Forbidden value on nameId = " + nameId + ", it doesn't respect the following condition : nameId < 0");
            

}


}


}