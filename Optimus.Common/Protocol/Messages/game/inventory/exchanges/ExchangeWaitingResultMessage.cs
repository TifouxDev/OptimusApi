


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeWaitingResultMessage : NetworkMessage
{

public const uint Id = 5786;
public override uint MessageId
{
    get { return Id; }
}

public bool bwait;
        

public ExchangeWaitingResultMessage()
{
}

public ExchangeWaitingResultMessage(bool bwait)
        {
            this.bwait = bwait;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(bwait);
            

}

public override void Deserialize(BigEndianReader reader)
{

bwait = reader.ReadBoolean();
            

}


}


}