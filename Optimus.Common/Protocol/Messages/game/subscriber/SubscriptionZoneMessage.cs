


















// Generated on 10/27/2013 07:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class SubscriptionZoneMessage : NetworkMessage
{

public const uint Id = 5573;
public override uint MessageId
{
    get { return Id; }
}

public bool active;
        

public SubscriptionZoneMessage()
{
}

public SubscriptionZoneMessage(bool active)
        {
            this.active = active;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(active);
            

}

public override void Deserialize(BigEndianReader reader)
{

active = reader.ReadBoolean();
            

}


}


}