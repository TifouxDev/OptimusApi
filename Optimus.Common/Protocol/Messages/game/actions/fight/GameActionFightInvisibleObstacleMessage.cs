


















// Generated on 10/27/2013 07:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightInvisibleObstacleMessage : AbstractGameActionMessage
{

public const uint Id = 5820;
public override uint MessageId
{
    get { return Id; }
}

public int sourceSpellId;
        

public GameActionFightInvisibleObstacleMessage()
{
}

public GameActionFightInvisibleObstacleMessage(short actionId, int sourceId, int sourceSpellId)
         : base(actionId, sourceId)
        {
            this.sourceSpellId = sourceSpellId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(sourceSpellId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            sourceSpellId = reader.ReadInt();
            if (sourceSpellId < 0)
                throw new Exception("Forbidden value on sourceSpellId = " + sourceSpellId + ", it doesn't respect the following condition : sourceSpellId < 0");
            

}


}


}