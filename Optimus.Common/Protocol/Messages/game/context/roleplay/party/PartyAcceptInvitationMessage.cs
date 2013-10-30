


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyAcceptInvitationMessage : AbstractPartyMessage
{

public const uint Id = 5580;
public override uint MessageId
{
    get { return Id; }
}



public PartyAcceptInvitationMessage()
{
}

public PartyAcceptInvitationMessage(int partyId)
         : base(partyId)
        {
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            

}


}


}