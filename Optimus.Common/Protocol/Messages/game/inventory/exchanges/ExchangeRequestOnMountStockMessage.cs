


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeRequestOnMountStockMessage : NetworkMessage
{

public const uint Id = 5986;
public override uint MessageId
{
    get { return Id; }
}



public ExchangeRequestOnMountStockMessage()
{
}



public override void Serialize(BigEndianWriter writer)
{



}

public override void Deserialize(BigEndianReader reader)
{



}


}


}