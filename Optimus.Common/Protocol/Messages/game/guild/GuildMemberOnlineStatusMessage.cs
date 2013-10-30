


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildMemberOnlineStatusMessage : NetworkMessage
{

public const uint Id = 6061;
public override uint MessageId
{
    get { return Id; }
}

public int memberId;
        public bool online;
        

public GuildMemberOnlineStatusMessage()
{
}

public GuildMemberOnlineStatusMessage(int memberId, bool online)
        {
            this.memberId = memberId;
            this.online = online;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(memberId);
            writer.WriteBoolean(online);
            

}

public override void Deserialize(BigEndianReader reader)
{

memberId = reader.ReadInt();
            if (memberId < 0)
                throw new Exception("Forbidden value on memberId = " + memberId + ", it doesn't respect the following condition : memberId < 0");
            online = reader.ReadBoolean();
            

}


}


}