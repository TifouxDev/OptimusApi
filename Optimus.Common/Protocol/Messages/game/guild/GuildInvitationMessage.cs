


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildInvitationMessage : NetworkMessage
{

public const uint Id = 5551;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        

public GuildInvitationMessage()
{
}

public GuildInvitationMessage(int targetId)
        {
            this.targetId = targetId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(targetId);
            

}

public override void Deserialize(BigEndianReader reader)
{

targetId = reader.ReadInt();
            if (targetId < 0)
                throw new Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < 0");
            

}


}


}