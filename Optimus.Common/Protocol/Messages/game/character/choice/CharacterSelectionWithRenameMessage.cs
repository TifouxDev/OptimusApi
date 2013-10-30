


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharacterSelectionWithRenameMessage : CharacterSelectionMessage
{

public const uint Id = 6121;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        

public CharacterSelectionWithRenameMessage()
{
}

public CharacterSelectionWithRenameMessage(int id, string name)
         : base(id)
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