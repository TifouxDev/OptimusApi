


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ServerSelectionMessage : NetworkMessage
{

public const uint Id = 40;
public override uint MessageId
{
    get { return Id; }
}

public short serverId;
        

public ServerSelectionMessage()
{
}

public ServerSelectionMessage(short serverId)
        {
            this.serverId = serverId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(serverId);
            

}

public override void Deserialize(BigEndianReader reader)
{

serverId = reader.ReadShort();
            

}


}


}