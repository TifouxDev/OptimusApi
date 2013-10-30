


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildMembershipMessage : GuildJoinedMessage
{

public const uint Id = 5835;
public override uint MessageId
{
    get { return Id; }
}



public GuildMembershipMessage()
{
}

public GuildMembershipMessage(Types.GuildInformations guildInfo, uint memberRights, bool enabled)
         : base(guildInfo, memberRights, enabled)
        {
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            

}


}


}