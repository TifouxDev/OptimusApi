


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ChallengeInfoMessage : NetworkMessage
{

public const uint Id = 6022;
public override uint MessageId
{
    get { return Id; }
}

public short challengeId;
        public int targetId;
        public int xpBonus;
        public int dropBonus;
        

public ChallengeInfoMessage()
{
}

public ChallengeInfoMessage(short challengeId, int targetId, int xpBonus, int dropBonus)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
            this.xpBonus = xpBonus;
            this.dropBonus = dropBonus;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(challengeId);
            writer.WriteInt(targetId);
            writer.WriteInt(xpBonus);
            writer.WriteInt(dropBonus);
            

}

public override void Deserialize(BigEndianReader reader)
{

challengeId = reader.ReadShort();
            if (challengeId < 0)
                throw new Exception("Forbidden value on challengeId = " + challengeId + ", it doesn't respect the following condition : challengeId < 0");
            targetId = reader.ReadInt();
            xpBonus = reader.ReadInt();
            if (xpBonus < 0)
                throw new Exception("Forbidden value on xpBonus = " + xpBonus + ", it doesn't respect the following condition : xpBonus < 0");
            dropBonus = reader.ReadInt();
            if (dropBonus < 0)
                throw new Exception("Forbidden value on dropBonus = " + dropBonus + ", it doesn't respect the following condition : dropBonus < 0");
            

}


}


}