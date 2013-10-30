


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeRequestedMessage : NetworkMessage
{

public const uint Id = 5522;
public override uint MessageId
{
    get { return Id; }
}

public sbyte exchangeType;
        

public ExchangeRequestedMessage()
{
}

public ExchangeRequestedMessage(sbyte exchangeType)
        {
            this.exchangeType = exchangeType;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(exchangeType);
            

}

public override void Deserialize(BigEndianReader reader)
{

exchangeType = reader.ReadSByte();
            

}


}


}