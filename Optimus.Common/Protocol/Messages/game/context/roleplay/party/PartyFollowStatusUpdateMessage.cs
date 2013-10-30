


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyFollowStatusUpdateMessage : AbstractPartyMessage
{

public const uint Id = 5581;
public override uint MessageId
{
    get { return Id; }
}

public bool success;
        public int followedId;
        

public PartyFollowStatusUpdateMessage()
{
}

public PartyFollowStatusUpdateMessage(int partyId, bool success, int followedId)
         : base(partyId)
        {
            this.success = success;
            this.followedId = followedId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(success);
            writer.WriteInt(followedId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            success = reader.ReadBoolean();
            followedId = reader.ReadInt();
            if (followedId < 0)
                throw new Exception("Forbidden value on followedId = " + followedId + ", it doesn't respect the following condition : followedId < 0");
            

}


}


}