


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class IdentificationFailedForBadVersionMessage : IdentificationFailedMessage
{

public const uint Id = 21;
public override uint MessageId
{
    get { return Id; }
}

public Types.Version requiredVersion;
        

public IdentificationFailedForBadVersionMessage()
{
}

public IdentificationFailedForBadVersionMessage(sbyte reason, Types.Version requiredVersion)
         : base(reason)
        {
            this.requiredVersion = requiredVersion;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            requiredVersion.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            requiredVersion = new Types.Version();
            requiredVersion.Deserialize(reader);
            

}


}


}