


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharacterReplayWithRenameRequestMessage : CharacterReplayRequestMessage
{

public const uint Id = 6122;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        

public CharacterReplayWithRenameRequestMessage()
{
}

public CharacterReplayWithRenameRequestMessage(int characterId, string name)
         : base(characterId)
        {
            this.name = name;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            

}


}


}