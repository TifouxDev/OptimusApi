


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MountRidingMessage : NetworkMessage
{

public const uint Id = 5967;
public override uint MessageId
{
    get { return Id; }
}

public bool isRiding;
        

public MountRidingMessage()
{
}

public MountRidingMessage(bool isRiding)
        {
            this.isRiding = isRiding;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(isRiding);
            

}

public override void Deserialize(BigEndianReader reader)
{

isRiding = reader.ReadBoolean();
            

}


}


}