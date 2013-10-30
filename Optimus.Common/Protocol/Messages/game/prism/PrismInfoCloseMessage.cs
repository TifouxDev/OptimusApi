


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PrismInfoCloseMessage : NetworkMessage
{

public const uint Id = 5853;
public override uint MessageId
{
    get { return Id; }
}



public PrismInfoCloseMessage()
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