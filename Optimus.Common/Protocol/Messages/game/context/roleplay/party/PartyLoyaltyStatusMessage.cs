


















// Generated on 10/27/2013 07:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyLoyaltyStatusMessage : AbstractPartyMessage
{

public const uint Id = 6270;
public override uint MessageId
{
    get { return Id; }
}

public bool loyal;
        

public PartyLoyaltyStatusMessage()
{
}

public PartyLoyaltyStatusMessage(int partyId, bool loyal)
         : base(partyId)
        {
            this.loyal = loyal;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(loyal);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            loyal = reader.ReadBoolean();
            

}


}


}