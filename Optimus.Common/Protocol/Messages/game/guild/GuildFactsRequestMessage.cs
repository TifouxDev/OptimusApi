


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildFactsRequestMessage : NetworkMessage
{

public const uint Id = 6404;
public override uint MessageId
{
    get { return Id; }
}

public int guildId;
        

public GuildFactsRequestMessage()
{
}

public GuildFactsRequestMessage(int guildId)
        {
            this.guildId = guildId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(guildId);
            

}

public override void Deserialize(BigEndianReader reader)
{

guildId = reader.ReadInt();
            if (guildId < 0)
                throw new Exception("Forbidden value on guildId = " + guildId + ", it doesn't respect the following condition : guildId < 0");
            

}


}


}