


















// Generated on 10/27/2013 07:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyLeaderUpdateMessage : AbstractPartyEventMessage
{

public const uint Id = 5578;
public override uint MessageId
{
    get { return Id; }
}

public int partyLeaderId;
        

public PartyLeaderUpdateMessage()
{
}

public PartyLeaderUpdateMessage(int partyId, int partyLeaderId)
         : base(partyId)
        {
            this.partyLeaderId = partyLeaderId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(partyLeaderId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            partyLeaderId = reader.ReadInt();
            if (partyLeaderId < 0)
                throw new Exception("Forbidden value on partyLeaderId = " + partyLeaderId + ", it doesn't respect the following condition : partyLeaderId < 0");
            

}


}


}