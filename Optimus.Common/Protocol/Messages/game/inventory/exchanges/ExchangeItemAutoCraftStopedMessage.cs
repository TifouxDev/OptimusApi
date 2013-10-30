


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeItemAutoCraftStopedMessage : NetworkMessage
{

public const uint Id = 5810;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public ExchangeItemAutoCraftStopedMessage()
{
}

public ExchangeItemAutoCraftStopedMessage(sbyte reason)
        {
            this.reason = reason;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(reason);
            

}

public override void Deserialize(BigEndianReader reader)
{

reason = reader.ReadSByte();
            

}


}


}