


















// Generated on 10/27/2013 07:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class FriendDeleteResultMessage : NetworkMessage
{

public const uint Id = 5601;
public override uint MessageId
{
    get { return Id; }
}

public bool success;
        public string name;
        

public FriendDeleteResultMessage()
{
}

public FriendDeleteResultMessage(bool success, string name)
        {
            this.success = success;
            this.name = name;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(success);
            writer.WriteUTF(name);
            

}

public override void Deserialize(BigEndianReader reader)
{

success = reader.ReadBoolean();
            name = reader.ReadUTF();
            

}


}


}