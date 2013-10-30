


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class QuestActiveInformations
{

public const short Id = 381;
public virtual short TypeId
{
    get { return Id; }
}

public short questId;
        

public QuestActiveInformations()
{
}

public QuestActiveInformations(short questId)
        {
            this.questId = questId;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteShort(questId);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

questId = reader.ReadShort();
            if (questId < 0)
                throw new Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
            

}


}


}