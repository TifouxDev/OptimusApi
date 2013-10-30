


















// Generated on 10/27/2013 07:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyRestrictedMessage : AbstractPartyMessage
{

public const uint Id = 6175;
public override uint MessageId
{
    get { return Id; }
}

public bool restricted;
        

public PartyRestrictedMessage()
{
}

public PartyRestrictedMessage(int partyId, bool restricted)
         : base(partyId)
        {
            this.restricted = restricted;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(restricted);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            restricted = reader.ReadBoolean();
            

}


}


}