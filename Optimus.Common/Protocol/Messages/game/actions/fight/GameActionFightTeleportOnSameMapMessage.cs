


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightTeleportOnSameMapMessage : AbstractGameActionMessage
{

public const uint Id = 5528;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public short cellId;
        

public GameActionFightTeleportOnSameMapMessage()
{
}

public GameActionFightTeleportOnSameMapMessage(short actionId, int sourceId, int targetId, short cellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteShort(cellId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            cellId = reader.ReadShort();
            if (cellId < -1 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < -1 || cellId > 559");
            

}


}


}