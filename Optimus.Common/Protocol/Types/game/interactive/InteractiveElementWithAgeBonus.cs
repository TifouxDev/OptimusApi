


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class InteractiveElementWithAgeBonus : InteractiveElement
{

public const short Id = 398;
public override short TypeId
{
    get { return Id; }
}

public short ageBonus;
        

public InteractiveElementWithAgeBonus()
{
}

public InteractiveElementWithAgeBonus(int elementId, int elementTypeId, Types.InteractiveElementSkill[] enabledSkills, Types.InteractiveElementSkill[] disabledSkills, short ageBonus)
         : base(elementId, elementTypeId, enabledSkills, disabledSkills)
        {
            this.ageBonus = ageBonus;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(ageBonus);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            ageBonus = reader.ReadShort();
            if (ageBonus < -1 || ageBonus > 1000)
                throw new Exception("Forbidden value on ageBonus = " + ageBonus + ", it doesn't respect the following condition : ageBonus < -1 || ageBonus > 1000");
            

}


}


}