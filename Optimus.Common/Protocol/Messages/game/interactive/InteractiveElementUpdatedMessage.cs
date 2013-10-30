


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class InteractiveElementUpdatedMessage : NetworkMessage
{

public const uint Id = 5708;
public override uint MessageId
{
    get { return Id; }
}

public Types.InteractiveElement interactiveElement;
        

public InteractiveElementUpdatedMessage()
{
}

public InteractiveElementUpdatedMessage(Types.InteractiveElement interactiveElement)
        {
            this.interactiveElement = interactiveElement;
        }
        

public override void Serialize(BigEndianWriter writer)
{

interactiveElement.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

interactiveElement = new Types.InteractiveElement();
            interactiveElement.Deserialize(reader);
            

}


}


}