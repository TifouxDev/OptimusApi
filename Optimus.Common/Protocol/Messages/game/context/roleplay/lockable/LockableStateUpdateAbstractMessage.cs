


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class LockableStateUpdateAbstractMessage : NetworkMessage
{

public const uint Id = 5671;
public override uint MessageId
{
    get { return Id; }
}

public bool locked;
        

public LockableStateUpdateAbstractMessage()
{
}

public LockableStateUpdateAbstractMessage(bool locked)
        {
            this.locked = locked;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(locked);
            

}

public override void Deserialize(BigEndianReader reader)
{

locked = reader.ReadBoolean();
            

}


}


}