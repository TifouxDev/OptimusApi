


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class DungeonKeyRingUpdateMessage : NetworkMessage
{

public const uint Id = 6296;
public override uint MessageId
{
    get { return Id; }
}

public short dungeonId;
        public bool available;
        

public DungeonKeyRingUpdateMessage()
{
}

public DungeonKeyRingUpdateMessage(short dungeonId, bool available)
        {
            this.dungeonId = dungeonId;
            this.available = available;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(dungeonId);
            writer.WriteBoolean(available);
            

}

public override void Deserialize(BigEndianReader reader)
{

dungeonId = reader.ReadShort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            available = reader.ReadBoolean();
            

}


}


}