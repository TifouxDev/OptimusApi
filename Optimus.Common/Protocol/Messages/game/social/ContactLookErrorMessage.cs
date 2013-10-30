


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ContactLookErrorMessage : NetworkMessage
{

public const uint Id = 6045;
public override uint MessageId
{
    get { return Id; }
}

public int requestId;
        

public ContactLookErrorMessage()
{
}

public ContactLookErrorMessage(int requestId)
        {
            this.requestId = requestId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(requestId);
            

}

public override void Deserialize(BigEndianReader reader)
{

requestId = reader.ReadInt();
            if (requestId < 0)
                throw new Exception("Forbidden value on requestId = " + requestId + ", it doesn't respect the following condition : requestId < 0");
            

}


}


}