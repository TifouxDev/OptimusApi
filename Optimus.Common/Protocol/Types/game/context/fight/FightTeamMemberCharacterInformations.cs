


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FightTeamMemberCharacterInformations : FightTeamMemberInformations
{

public const short Id = 13;
public override short TypeId
{
    get { return Id; }
}

public string name;
        public short level;
        

public FightTeamMemberCharacterInformations()
{
}

public FightTeamMemberCharacterInformations(int id, string name, short level)
         : base(id)
        {
            this.name = name;
            this.level = level;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteShort(level);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            level = reader.ReadShort();
            if (level < 0)
                throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 0");
            

}


}


}