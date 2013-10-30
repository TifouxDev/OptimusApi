


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ServerStatusUpdateMessage : NetworkMessage
{

public const uint Id = 50;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameServerInformations server;
        

public ServerStatusUpdateMessage()
{
}

public ServerStatusUpdateMessage(Types.GameServerInformations server)
        {
            this.server = server;
        }
        

public override void Serialize(BigEndianWriter writer)
{

server.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

server = new Types.GameServerInformations();
            server.Deserialize(reader);
            

}


}


}