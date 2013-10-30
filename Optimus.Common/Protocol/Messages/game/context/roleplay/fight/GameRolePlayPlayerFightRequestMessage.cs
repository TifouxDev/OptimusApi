


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameRolePlayPlayerFightRequestMessage : NetworkMessage
{

public const uint Id = 5731;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public short targetCellId;
        public bool friendly;
        

public GameRolePlayPlayerFightRequestMessage()
{
}

public GameRolePlayPlayerFightRequestMessage(int targetId, short targetCellId, bool friendly)
        {
            this.targetId = targetId;
            this.targetCellId = targetCellId;
            this.friendly = friendly;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(targetId);
            writer.WriteShort(targetCellId);
            writer.WriteBoolean(friendly);
            

}

public override void Deserialize(BigEndianReader reader)
{

targetId = reader.ReadInt();
            if (targetId < 0)
                throw new Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < 0");
            targetCellId = reader.ReadShort();
            if (targetCellId < -1 || targetCellId > 559)
                throw new Exception("Forbidden value on targetCellId = " + targetCellId + ", it doesn't respect the following condition : targetCellId < -1 || targetCellId > 559");
            friendly = reader.ReadBoolean();
            

}


}


}