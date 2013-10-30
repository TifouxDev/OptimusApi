


















// Generated on 10/27/2013 07:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ObjectModifiedMessage : NetworkMessage
{

public const uint Id = 3029;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem @object;
        

public ObjectModifiedMessage()
{
}

public ObjectModifiedMessage(Types.ObjectItem @object)
        {
            this.@object = @object;
        }
        

public override void Serialize(BigEndianWriter writer)
{

@object.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

@object = new Types.ObjectItem();
            @object.Deserialize(reader);
            

}


}


}