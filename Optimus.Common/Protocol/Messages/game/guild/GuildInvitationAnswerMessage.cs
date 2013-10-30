


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildInvitationAnswerMessage : NetworkMessage
{

public const uint Id = 5556;
public override uint MessageId
{
    get { return Id; }
}

public bool accept;
        

public GuildInvitationAnswerMessage()
{
}

public GuildInvitationAnswerMessage(bool accept)
        {
            this.accept = accept;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(accept);
            

}

public override void Deserialize(BigEndianReader reader)
{

accept = reader.ReadBoolean();
            

}


}


}