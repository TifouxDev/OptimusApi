


















// Generated on 10/27/2013 07:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyInvitationCancelledForGuestMessage : AbstractPartyMessage
{

public const uint Id = 6256;
public override uint MessageId
{
    get { return Id; }
}

public int cancelerId;
        

public PartyInvitationCancelledForGuestMessage()
{
}

public PartyInvitationCancelledForGuestMessage(int partyId, int cancelerId)
         : base(partyId)
        {
            this.cancelerId = cancelerId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(cancelerId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            cancelerId = reader.ReadInt();
            if (cancelerId < 0)
                throw new Exception("Forbidden value on cancelerId = " + cancelerId + ", it doesn't respect the following condition : cancelerId < 0");
            

}


}


}