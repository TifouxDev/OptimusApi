


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class GuildInformations : BasicGuildInformations
{

public const short Id = 127;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildEmblem guildEmblem;
        

public GuildInformations()
{
}

public GuildInformations(int guildId, string guildName, Types.GuildEmblem guildEmblem)
         : base(guildId, guildName)
        {
            this.guildEmblem = guildEmblem;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            guildEmblem.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
            

}


}


}