


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AchievementDetailsRequestMessage : NetworkMessage
{

public const uint Id = 6380;
public override uint MessageId
{
    get { return Id; }
}

public short achievementId;
        

public AchievementDetailsRequestMessage()
{
}

public AchievementDetailsRequestMessage(short achievementId)
        {
            this.achievementId = achievementId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(achievementId);
            

}

public override void Deserialize(BigEndianReader reader)
{

achievementId = reader.ReadShort();
            if (achievementId < 0)
                throw new Exception("Forbidden value on achievementId = " + achievementId + ", it doesn't respect the following condition : achievementId < 0");
            

}


}


}