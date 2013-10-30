


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ServersListMessage : NetworkMessage
{

public const uint Id = 30;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameServerInformations[] servers;
        

public ServersListMessage()
{
}

public ServersListMessage(Types.GameServerInformations[] servers)
        {
            this.servers = servers;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)servers.Length);
            foreach (var entry in servers)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            servers = new Types.GameServerInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 servers[i] = new Types.GameServerInformations();
                 servers[i].Deserialize(reader);
            }
            

}


}


}