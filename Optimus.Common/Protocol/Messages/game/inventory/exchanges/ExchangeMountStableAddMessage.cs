


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeMountStableAddMessage : NetworkMessage
{

public const uint Id = 5971;
public override uint MessageId
{
    get { return Id; }
}

public Types.MountClientData mountDescription;
        

public ExchangeMountStableAddMessage()
{
}

public ExchangeMountStableAddMessage(Types.MountClientData mountDescription)
        {
            this.mountDescription = mountDescription;
        }
        

public override void Serialize(BigEndianWriter writer)
{

mountDescription.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

mountDescription = new Types.MountClientData();
            mountDescription.Deserialize(reader);
            

}


}


}