


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharacterSelectionMessage : NetworkMessage
{

public const uint Id = 152;
public override uint MessageId
{
    get { return Id; }
}

public int id;
        

public CharacterSelectionMessage()
{
}

public CharacterSelectionMessage(int id)
        {
            this.id = id;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(id);
            

}

public override void Deserialize(BigEndianReader reader)
{

id = reader.ReadInt();
            if (id < 1 || id > 2147483647)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 1 || id > 2147483647");
            

}


}


}