


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharacterLevelUpInformationMessage : CharacterLevelUpMessage
{

public const uint Id = 6076;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public int id;
        

public CharacterLevelUpInformationMessage()
{
}

public CharacterLevelUpInformationMessage(byte newLevel, string name, int id)
         : base(newLevel)
        {
            this.name = name;
            this.id = id;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteInt(id);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            id = reader.ReadInt();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            

}


}


}