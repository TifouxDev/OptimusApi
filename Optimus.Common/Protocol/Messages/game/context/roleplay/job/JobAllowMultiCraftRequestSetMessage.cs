


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class JobAllowMultiCraftRequestSetMessage : NetworkMessage
{

public const uint Id = 5749;
public override uint MessageId
{
    get { return Id; }
}

public bool enabled;
        

public JobAllowMultiCraftRequestSetMessage()
{
}

public JobAllowMultiCraftRequestSetMessage(bool enabled)
        {
            this.enabled = enabled;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(enabled);
            

}

public override void Deserialize(BigEndianReader reader)
{

enabled = reader.ReadBoolean();
            

}


}


}