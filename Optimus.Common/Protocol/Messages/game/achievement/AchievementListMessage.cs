


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AchievementListMessage : NetworkMessage
{

public const uint Id = 6205;
public override uint MessageId
{
    get { return Id; }
}

public short[] finishedAchievementsIds;
        public Types.AchievementRewardable[] rewardableAchievements;
        

public AchievementListMessage()
{
}

public AchievementListMessage(short[] finishedAchievementsIds, Types.AchievementRewardable[] rewardableAchievements)
        {
            this.finishedAchievementsIds = finishedAchievementsIds;
            this.rewardableAchievements = rewardableAchievements;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)finishedAchievementsIds.Length);
            foreach (var entry in finishedAchievementsIds)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteUShort((ushort)rewardableAchievements.Length);
            foreach (var entry in rewardableAchievements)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            finishedAchievementsIds = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 finishedAchievementsIds[i] = reader.ReadShort();
            }
            limit = reader.ReadUShort();
            rewardableAchievements = new Types.AchievementRewardable[limit];
            for (int i = 0; i < limit; i++)
            {
                 rewardableAchievements[i] = new Types.AchievementRewardable();
                 rewardableAchievements[i].Deserialize(reader);
            }
            

}


}


}