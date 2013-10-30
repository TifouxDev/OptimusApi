


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildInvitedMessage : NetworkMessage
{

public const uint Id = 5552;
public override uint MessageId
{
    get { return Id; }
}

public int recruterId;
        public string recruterName;
        public Types.BasicGuildInformations guildInfo;
        

public GuildInvitedMessage()
{
}

public GuildInvitedMessage(int recruterId, string recruterName, Types.BasicGuildInformations guildInfo)
        {
            this.recruterId = recruterId;
            this.recruterName = recruterName;
            this.guildInfo = guildInfo;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(recruterId);
            writer.WriteUTF(recruterName);
            guildInfo.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

recruterId = reader.ReadInt();
            if (recruterId < 0)
                throw new Exception("Forbidden value on recruterId = " + recruterId + ", it doesn't respect the following condition : recruterId < 0");
            recruterName = reader.ReadUTF();
            guildInfo = new Types.BasicGuildInformations();
            guildInfo.Deserialize(reader);
            

}


}


}