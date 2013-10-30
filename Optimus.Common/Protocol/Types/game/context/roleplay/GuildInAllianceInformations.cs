


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class GuildInAllianceInformations : GuildInformations
{

public const short Id = 420;
public override short TypeId
{
    get { return Id; }
}

public ushort guildLevel;
        public ushort nbMembers;
        public bool enabled;
        

public GuildInAllianceInformations()
{
}

public GuildInAllianceInformations(int guildId, string guildName, Types.GuildEmblem guildEmblem, ushort guildLevel, ushort nbMembers, bool enabled)
         : base(guildId, guildName, guildEmblem)
        {
            this.guildLevel = guildLevel;
            this.nbMembers = nbMembers;
            this.enabled = enabled;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort(guildLevel);
            writer.WriteUShort(nbMembers);
            writer.WriteBoolean(enabled);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            guildLevel = reader.ReadUShort();
            if (guildLevel < 0 || guildLevel > 65535)
                throw new Exception("Forbidden value on guildLevel = " + guildLevel + ", it doesn't respect the following condition : guildLevel < 0 || guildLevel > 65535");
            nbMembers = reader.ReadUShort();
            if (nbMembers < 0 || nbMembers > 65535)
                throw new Exception("Forbidden value on nbMembers = " + nbMembers + ", it doesn't respect the following condition : nbMembers < 0 || nbMembers > 65535");
            enabled = reader.ReadBoolean();
            

}


}


}