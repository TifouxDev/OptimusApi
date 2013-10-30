


















// Generated on 10/27/2013 07:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TrustStatusMessage : NetworkMessage
{

public const uint Id = 6267;
public override uint MessageId
{
    get { return Id; }
}

public bool trusted;
        

public TrustStatusMessage()
{
}

public TrustStatusMessage(bool trusted)
        {
            this.trusted = trusted;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(trusted);
            

}

public override void Deserialize(BigEndianReader reader)
{

trusted = reader.ReadBoolean();
            

}


}


}