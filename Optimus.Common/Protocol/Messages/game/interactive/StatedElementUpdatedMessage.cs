


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class StatedElementUpdatedMessage : NetworkMessage
{

public const uint Id = 5709;
public override uint MessageId
{
    get { return Id; }
}

public Types.StatedElement statedElement;
        

public StatedElementUpdatedMessage()
{
}

public StatedElementUpdatedMessage(Types.StatedElement statedElement)
        {
            this.statedElement = statedElement;
        }
        

public override void Serialize(BigEndianWriter writer)
{

statedElement.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

statedElement = new Types.StatedElement();
            statedElement.Deserialize(reader);
            

}


}


}