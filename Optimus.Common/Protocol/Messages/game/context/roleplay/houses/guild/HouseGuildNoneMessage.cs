


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class HouseGuildNoneMessage : NetworkMessage
{

public const uint Id = 5701;
public override uint MessageId
{
    get { return Id; }
}

public short houseId;
        

public HouseGuildNoneMessage()
{
}

public HouseGuildNoneMessage(short houseId)
        {
            this.houseId = houseId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(houseId);
            

}

public override void Deserialize(BigEndianReader reader)
{

houseId = reader.ReadShort();
            if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            

}


}


}