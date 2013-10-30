


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AcquaintanceServerListMessage : NetworkMessage
{

public const uint Id = 6142;
public override uint MessageId
{
    get { return Id; }
}

public short[] servers;
        

public AcquaintanceServerListMessage()
{
}

public AcquaintanceServerListMessage(short[] servers)
        {
            this.servers = servers;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)servers.Length);
            foreach (var entry in servers)
            {
                 writer.WriteShort(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            servers = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 servers[i] = reader.ReadShort();
            }
            

}


}


}