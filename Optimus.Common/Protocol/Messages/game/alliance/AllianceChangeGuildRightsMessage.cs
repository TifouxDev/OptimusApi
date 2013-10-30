


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceChangeGuildRightsMessage : NetworkMessage
{

public const uint Id = 6426;
public override uint MessageId
{
    get { return Id; }
}

public int guildId;
        public sbyte rights;
        

public AllianceChangeGuildRightsMessage()
{
}

public AllianceChangeGuildRightsMessage(int guildId, sbyte rights)
        {
            this.guildId = guildId;
            this.rights = rights;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(guildId);
            writer.WriteSByte(rights);
            

}

public override void Deserialize(BigEndianReader reader)
{

guildId = reader.ReadInt();
            if (guildId < 0)
                throw new Exception("Forbidden value on guildId = " + guildId + ", it doesn't respect the following condition : guildId < 0");
            rights = reader.ReadSByte();
            if (rights < 0)
                throw new Exception("Forbidden value on rights = " + rights + ", it doesn't respect the following condition : rights < 0");
            

}


}


}