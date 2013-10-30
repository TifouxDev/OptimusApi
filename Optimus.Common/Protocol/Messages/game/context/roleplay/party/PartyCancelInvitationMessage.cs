


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyCancelInvitationMessage : AbstractPartyMessage
{

public const uint Id = 6254;
public override uint MessageId
{
    get { return Id; }
}

public int guestId;
        

public PartyCancelInvitationMessage()
{
}

public PartyCancelInvitationMessage(int partyId, int guestId)
         : base(partyId)
        {
            this.guestId = guestId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(guestId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            guestId = reader.ReadInt();
            if (guestId < 0)
                throw new Exception("Forbidden value on guestId = " + guestId + ", it doesn't respect the following condition : guestId < 0");
            

}


}


}