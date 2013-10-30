


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildInvitationStateRecruterMessage : NetworkMessage
{

public const uint Id = 5563;
public override uint MessageId
{
    get { return Id; }
}

public string recrutedName;
        public sbyte invitationState;
        

public GuildInvitationStateRecruterMessage()
{
}

public GuildInvitationStateRecruterMessage(string recrutedName, sbyte invitationState)
        {
            this.recrutedName = recrutedName;
            this.invitationState = invitationState;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(recrutedName);
            writer.WriteSByte(invitationState);
            

}

public override void Deserialize(BigEndianReader reader)
{

recrutedName = reader.ReadUTF();
            invitationState = reader.ReadSByte();
            if (invitationState < 0)
                throw new Exception("Forbidden value on invitationState = " + invitationState + ", it doesn't respect the following condition : invitationState < 0");
            

}


}


}