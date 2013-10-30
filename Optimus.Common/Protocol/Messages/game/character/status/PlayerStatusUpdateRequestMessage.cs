


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PlayerStatusUpdateRequestMessage : NetworkMessage
{

public const uint Id = 6387;
public override uint MessageId
{
    get { return Id; }
}

public Types.PlayerStatus status;
        

public PlayerStatusUpdateRequestMessage()
{
}

public PlayerStatusUpdateRequestMessage(Types.PlayerStatus status)
        {
            this.status = status;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

status = Types.ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadShort());
            status.Deserialize(reader);
            

}


}


}