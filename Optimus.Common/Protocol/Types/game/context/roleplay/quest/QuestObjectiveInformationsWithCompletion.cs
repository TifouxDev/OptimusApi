


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class QuestObjectiveInformationsWithCompletion : QuestObjectiveInformations
{

public const short Id = 386;
public override short TypeId
{
    get { return Id; }
}

public short curCompletion;
        public short maxCompletion;
        

public QuestObjectiveInformationsWithCompletion()
{
}

public QuestObjectiveInformationsWithCompletion(short objectiveId, bool objectiveStatus, string[] dialogParams, short curCompletion, short maxCompletion)
         : base(objectiveId, objectiveStatus, dialogParams)
        {
            this.curCompletion = curCompletion;
            this.maxCompletion = maxCompletion;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(curCompletion);
            writer.WriteShort(maxCompletion);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            curCompletion = reader.ReadShort();
            if (curCompletion < 0)
                throw new Exception("Forbidden value on curCompletion = " + curCompletion + ", it doesn't respect the following condition : curCompletion < 0");
            maxCompletion = reader.ReadShort();
            if (maxCompletion < 0)
                throw new Exception("Forbidden value on maxCompletion = " + maxCompletion + ", it doesn't respect the following condition : maxCompletion < 0");
            

}


}


}