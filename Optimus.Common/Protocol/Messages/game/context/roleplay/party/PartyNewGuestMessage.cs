


















// Generated on 10/27/2013 07:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyNewGuestMessage : AbstractPartyEventMessage
{

public const uint Id = 6260;
public override uint MessageId
{
    get { return Id; }
}

public Types.PartyGuestInformations guest;
        

public PartyNewGuestMessage()
{
}

public PartyNewGuestMessage(int partyId, Types.PartyGuestInformations guest)
         : base(partyId)
        {
            this.guest = guest;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            guest.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            guest = new Types.PartyGuestInformations();
            guest.Deserialize(reader);
            

}


}


}