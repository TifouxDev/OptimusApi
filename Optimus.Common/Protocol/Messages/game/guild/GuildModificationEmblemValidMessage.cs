


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildModificationEmblemValidMessage : NetworkMessage
{

public const uint Id = 6328;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildEmblem guildEmblem;
        

public GuildModificationEmblemValidMessage()
{
}

public GuildModificationEmblemValidMessage(Types.GuildEmblem guildEmblem)
        {
            this.guildEmblem = guildEmblem;
        }
        

public override void Serialize(BigEndianWriter writer)
{

guildEmblem.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
            

}


}


}