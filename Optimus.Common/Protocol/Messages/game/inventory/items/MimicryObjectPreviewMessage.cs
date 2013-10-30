


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MimicryObjectPreviewMessage : NetworkMessage
{

public const uint Id = 6458;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem result;
        

public MimicryObjectPreviewMessage()
{
}

public MimicryObjectPreviewMessage(Types.ObjectItem result)
        {
            this.result = result;
        }
        

public override void Serialize(BigEndianWriter writer)
{

result.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

result = new Types.ObjectItem();
            result.Deserialize(reader);
            

}


}


}