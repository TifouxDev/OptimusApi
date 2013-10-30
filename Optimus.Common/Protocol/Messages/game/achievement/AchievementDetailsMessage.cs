


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AchievementDetailsMessage : NetworkMessage
{

public const uint Id = 6378;
public override uint MessageId
{
    get { return Id; }
}

public Types.Achievement achievement;
        

public AchievementDetailsMessage()
{
}

public AchievementDetailsMessage(Types.Achievement achievement)
        {
            this.achievement = achievement;
        }
        

public override void Serialize(BigEndianWriter writer)
{

achievement.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

achievement = new Types.Achievement();
            achievement.Deserialize(reader);
            

}


}


}