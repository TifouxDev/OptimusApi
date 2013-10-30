


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TeleportOnSameMapMessage : NetworkMessage
{

public const uint Id = 6048;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public short cellId;
        

public TeleportOnSameMapMessage()
{
}

public TeleportOnSameMapMessage(int targetId, short cellId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(targetId);
            writer.WriteShort(cellId);
            

}

public override void Deserialize(BigEndianReader reader)
{

targetId = reader.ReadInt();
            cellId = reader.ReadShort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            

}


}


}