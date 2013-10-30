


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameContextReadyMessage : NetworkMessage
{

public const uint Id = 6071;
public override uint MessageId
{
    get { return Id; }
}

public int mapId;
        

public GameContextReadyMessage()
{
}

public GameContextReadyMessage(int mapId)
        {
            this.mapId = mapId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(mapId);
            

}

public override void Deserialize(BigEndianReader reader)
{

mapId = reader.ReadInt();
            if (mapId < 0)
                throw new Exception("Forbidden value on mapId = " + mapId + ", it doesn't respect the following condition : mapId < 0");
            

}


}


}