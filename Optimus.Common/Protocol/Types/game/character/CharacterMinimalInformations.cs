


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class CharacterMinimalInformations : AbstractCharacterInformation
{

public const short Id = 110;
public override short TypeId
{
    get { return Id; }
}

public byte level;
        public string name;
        

public CharacterMinimalInformations()
{
}

public CharacterMinimalInformations(int id, byte level, string name)
         : base(id)
        {
            this.level = level;
            this.name = name;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteByte(level);
            writer.WriteUTF(name);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            level = reader.ReadByte();
            if (level < 1 || level > 200)
                throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 1 || level > 200");
            name = reader.ReadUTF();
            

}


}


}