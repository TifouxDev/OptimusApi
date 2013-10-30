


















// Generated on 10/27/2013 07:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyMemberRemoveMessage : AbstractPartyEventMessage
{

public const uint Id = 5579;
public override uint MessageId
{
    get { return Id; }
}

public int leavingPlayerId;
        

public PartyMemberRemoveMessage()
{
}

public PartyMemberRemoveMessage(int partyId, int leavingPlayerId)
         : base(partyId)
        {
            this.leavingPlayerId = leavingPlayerId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(leavingPlayerId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            leavingPlayerId = reader.ReadInt();
            if (leavingPlayerId < 0)
                throw new Exception("Forbidden value on leavingPlayerId = " + leavingPlayerId + ", it doesn't respect the following condition : leavingPlayerId < 0");
            

}


}


}