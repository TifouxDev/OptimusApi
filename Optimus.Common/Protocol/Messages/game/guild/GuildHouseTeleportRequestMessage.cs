


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildHouseTeleportRequestMessage : NetworkMessage
{

public const uint Id = 5712;
public override uint MessageId
{
    get { return Id; }
}

public int houseId;
        

public GuildHouseTeleportRequestMessage()
{
}

public GuildHouseTeleportRequestMessage(int houseId)
        {
            this.houseId = houseId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(houseId);
            

}

public override void Deserialize(BigEndianReader reader)
{

houseId = reader.ReadInt();
            if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            

}


}


}