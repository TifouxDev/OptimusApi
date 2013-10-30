


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ChallengeTargetUpdateMessage : NetworkMessage
{

public const uint Id = 6123;
public override uint MessageId
{
    get { return Id; }
}

public short challengeId;
        public int targetId;
        

public ChallengeTargetUpdateMessage()
{
}

public ChallengeTargetUpdateMessage(short challengeId, int targetId)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(challengeId);
            writer.WriteInt(targetId);
            

}

public override void Deserialize(BigEndianReader reader)
{

challengeId = reader.ReadShort();
            if (challengeId < 0)
                throw new Exception("Forbidden value on challengeId = " + challengeId + ", it doesn't respect the following condition : challengeId < 0");
            targetId = reader.ReadInt();
            

}


}


}