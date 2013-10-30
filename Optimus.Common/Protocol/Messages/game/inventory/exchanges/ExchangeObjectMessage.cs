


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeObjectMessage : NetworkMessage
{

public const uint Id = 5515;
public override uint MessageId
{
    get { return Id; }
}

public bool remote;
        

public ExchangeObjectMessage()
{
}

public ExchangeObjectMessage(bool remote)
        {
            this.remote = remote;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(remote);
            

}

public override void Deserialize(BigEndianReader reader)
{

remote = reader.ReadBoolean();
            

}


}


}