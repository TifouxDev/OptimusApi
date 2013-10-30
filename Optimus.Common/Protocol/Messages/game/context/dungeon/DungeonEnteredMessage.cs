


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class DungeonEnteredMessage : NetworkMessage
{

public const uint Id = 6152;
public override uint MessageId
{
    get { return Id; }
}

public int dungeonId;
        

public DungeonEnteredMessage()
{
}

public DungeonEnteredMessage(int dungeonId)
        {
            this.dungeonId = dungeonId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(dungeonId);
            

}

public override void Deserialize(BigEndianReader reader)
{

dungeonId = reader.ReadInt();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            

}


}


}