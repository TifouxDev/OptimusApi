


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildMemberLeavingMessage : NetworkMessage
{

public const uint Id = 5923;
public override uint MessageId
{
    get { return Id; }
}

public bool kicked;
        public int memberId;
        

public GuildMemberLeavingMessage()
{
}

public GuildMemberLeavingMessage(bool kicked, int memberId)
        {
            this.kicked = kicked;
            this.memberId = memberId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(kicked);
            writer.WriteInt(memberId);
            

}

public override void Deserialize(BigEndianReader reader)
{

kicked = reader.ReadBoolean();
            memberId = reader.ReadInt();
            

}


}


}