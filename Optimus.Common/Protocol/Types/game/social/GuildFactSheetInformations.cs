


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class GuildFactSheetInformations : GuildInformations
{

public const short Id = 424;
public override short TypeId
{
    get { return Id; }
}

public int leaderId;
        public byte guildLevel;
        public short nbMembers;
        

public GuildFactSheetInformations()
{
}

public GuildFactSheetInformations(int guildId, string guildName, Types.GuildEmblem guildEmblem, int leaderId, byte guildLevel, short nbMembers)
         : base(guildId, guildName, guildEmblem)
        {
            this.leaderId = leaderId;
            this.guildLevel = guildLevel;
            this.nbMembers = nbMembers;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(leaderId);
            writer.WriteByte(guildLevel);
            writer.WriteShort(nbMembers);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            leaderId = reader.ReadInt();
            if (leaderId < 0)
                throw new Exception("Forbidden value on leaderId = " + leaderId + ", it doesn't respect the following condition : leaderId < 0");
            guildLevel = reader.ReadByte();
            if (guildLevel < 0 || guildLevel > 255)
                throw new Exception("Forbidden value on guildLevel = " + guildLevel + ", it doesn't respect the following condition : guildLevel < 0 || guildLevel > 255");
            nbMembers = reader.ReadShort();
            if (nbMembers < 0)
                throw new Exception("Forbidden value on nbMembers = " + nbMembers + ", it doesn't respect the following condition : nbMembers < 0");
            

}


}


}