


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class NotificationUpdateFlagMessage : NetworkMessage
{

public const uint Id = 6090;
public override uint MessageId
{
    get { return Id; }
}

public short index;
        

public NotificationUpdateFlagMessage()
{
}

public NotificationUpdateFlagMessage(short index)
        {
            this.index = index;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(index);
            

}

public override void Deserialize(BigEndianReader reader)
{

index = reader.ReadShort();
            if (index < 0)
                throw new Exception("Forbidden value on index = " + index + ", it doesn't respect the following condition : index < 0");
            

}


}


}