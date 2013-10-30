


















// Generated on 10/27/2013 07:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class QuestStartRequestMessage : NetworkMessage
{

public const uint Id = 5643;
public override uint MessageId
{
    get { return Id; }
}

public ushort questId;
        

public QuestStartRequestMessage()
{
}

public QuestStartRequestMessage(ushort questId)
        {
            this.questId = questId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort(questId);
            

}

public override void Deserialize(BigEndianReader reader)
{

questId = reader.ReadUShort();
            if (questId < 0 || questId > 65535)
                throw new Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0 || questId > 65535");
            

}


}


}