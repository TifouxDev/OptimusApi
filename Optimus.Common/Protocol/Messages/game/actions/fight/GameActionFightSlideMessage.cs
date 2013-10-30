


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightSlideMessage : AbstractGameActionMessage
{

public const uint Id = 5525;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public short startCellId;
        public short endCellId;
        

public GameActionFightSlideMessage()
{
}

public GameActionFightSlideMessage(short actionId, int sourceId, int targetId, short startCellId, short endCellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.startCellId = startCellId;
            this.endCellId = endCellId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteShort(startCellId);
            writer.WriteShort(endCellId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            startCellId = reader.ReadShort();
            if (startCellId < -1 || startCellId > 559)
                throw new Exception("Forbidden value on startCellId = " + startCellId + ", it doesn't respect the following condition : startCellId < -1 || startCellId > 559");
            endCellId = reader.ReadShort();
            if (endCellId < -1 || endCellId > 559)
                throw new Exception("Forbidden value on endCellId = " + endCellId + ", it doesn't respect the following condition : endCellId < -1 || endCellId > 559");
            

}


}


}