


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeMountStableBornAddMessage : ExchangeMountStableAddMessage
{

public const uint Id = 5966;
public override uint MessageId
{
    get { return Id; }
}



public ExchangeMountStableBornAddMessage()
{
}

public ExchangeMountStableBornAddMessage(Types.MountClientData mountDescription)
         : base(mountDescription)
        {
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            

}


}


}