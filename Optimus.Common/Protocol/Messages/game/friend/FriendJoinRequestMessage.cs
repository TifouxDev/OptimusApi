


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class FriendJoinRequestMessage : NetworkMessage
{

public const uint Id = 5605;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        

public FriendJoinRequestMessage()
{
}

public FriendJoinRequestMessage(string name)
        {
            this.name = name;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(name);
            

}

public override void Deserialize(BigEndianReader reader)
{

name = reader.ReadUTF();
            

}


}


}