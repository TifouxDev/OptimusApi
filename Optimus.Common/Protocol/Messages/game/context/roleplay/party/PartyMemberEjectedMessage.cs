


















// Generated on 10/27/2013 07:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyMemberEjectedMessage : PartyMemberRemoveMessage
{

public const uint Id = 6252;
public override uint MessageId
{
    get { return Id; }
}

public int kickerId;
        

public PartyMemberEjectedMessage()
{
}

public PartyMemberEjectedMessage(int partyId, int leavingPlayerId, int kickerId)
         : base(partyId, leavingPlayerId)
        {
            this.kickerId = kickerId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(kickerId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            kickerId = reader.ReadInt();
            if (kickerId < 0)
                throw new Exception("Forbidden value on kickerId = " + kickerId + ", it doesn't respect the following condition : kickerId < 0");
            

}


}


}