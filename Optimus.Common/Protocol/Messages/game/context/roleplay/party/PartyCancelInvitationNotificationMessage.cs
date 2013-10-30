


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyCancelInvitationNotificationMessage : AbstractPartyEventMessage
{

public const uint Id = 6251;
public override uint MessageId
{
    get { return Id; }
}

public int cancelerId;
        public int guestId;
        

public PartyCancelInvitationNotificationMessage()
{
}

public PartyCancelInvitationNotificationMessage(int partyId, int cancelerId, int guestId)
         : base(partyId)
        {
            this.cancelerId = cancelerId;
            this.guestId = guestId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(cancelerId);
            writer.WriteInt(guestId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            cancelerId = reader.ReadInt();
            if (cancelerId < 0)
                throw new Exception("Forbidden value on cancelerId = " + cancelerId + ", it doesn't respect the following condition : cancelerId < 0");
            guestId = reader.ReadInt();
            if (guestId < 0)
                throw new Exception("Forbidden value on guestId = " + guestId + ", it doesn't respect the following condition : guestId < 0");
            

}


}


}