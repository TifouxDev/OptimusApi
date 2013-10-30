


















// Generated on 10/27/2013 07:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class FriendAddedMessage : NetworkMessage
{

public const uint Id = 5599;
public override uint MessageId
{
    get { return Id; }
}

public Types.FriendInformations friendAdded;
        

public FriendAddedMessage()
{
}

public FriendAddedMessage(Types.FriendInformations friendAdded)
        {
            this.friendAdded = friendAdded;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(friendAdded.TypeId);
            friendAdded.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

friendAdded = Types.ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadShort());
            friendAdded.Deserialize(reader);
            

}


}


}