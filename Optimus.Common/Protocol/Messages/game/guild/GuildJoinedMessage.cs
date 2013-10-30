


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildJoinedMessage : NetworkMessage
{

public const uint Id = 5564;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildInformations guildInfo;
        public uint memberRights;
        public bool enabled;
        

public GuildJoinedMessage()
{
}

public GuildJoinedMessage(Types.GuildInformations guildInfo, uint memberRights, bool enabled)
        {
            this.guildInfo = guildInfo;
            this.memberRights = memberRights;
            this.enabled = enabled;
        }
        

public override void Serialize(BigEndianWriter writer)
{

guildInfo.Serialize(writer);
            writer.WriteUInt(memberRights);
            writer.WriteBoolean(enabled);
            

}

public override void Deserialize(BigEndianReader reader)
{

guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            memberRights = reader.ReadUInt();
            if (memberRights < 0 || memberRights > 4.294967295E9)
                throw new Exception("Forbidden value on memberRights = " + memberRights + ", it doesn't respect the following condition : memberRights < 0 || memberRights > 4.294967295E9");
            enabled = reader.ReadBoolean();
            

}


}


}