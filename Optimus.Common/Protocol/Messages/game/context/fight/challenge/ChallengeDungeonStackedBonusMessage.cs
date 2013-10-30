


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ChallengeDungeonStackedBonusMessage : NetworkMessage
{

public const uint Id = 6151;
public override uint MessageId
{
    get { return Id; }
}

public int dungeonId;
        public int xpBonus;
        public int dropBonus;
        

public ChallengeDungeonStackedBonusMessage()
{
}

public ChallengeDungeonStackedBonusMessage(int dungeonId, int xpBonus, int dropBonus)
        {
            this.dungeonId = dungeonId;
            this.xpBonus = xpBonus;
            this.dropBonus = dropBonus;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(dungeonId);
            writer.WriteInt(xpBonus);
            writer.WriteInt(dropBonus);
            

}

public override void Deserialize(BigEndianReader reader)
{

dungeonId = reader.ReadInt();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            xpBonus = reader.ReadInt();
            if (xpBonus < 0)
                throw new Exception("Forbidden value on xpBonus = " + xpBonus + ", it doesn't respect the following condition : xpBonus < 0");
            dropBonus = reader.ReadInt();
            if (dropBonus < 0)
                throw new Exception("Forbidden value on dropBonus = " + dropBonus + ", it doesn't respect the following condition : dropBonus < 0");
            

}


}


}