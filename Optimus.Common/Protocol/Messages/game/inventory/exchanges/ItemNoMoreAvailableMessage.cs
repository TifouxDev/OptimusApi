


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ItemNoMoreAvailableMessage : NetworkMessage
{

public const uint Id = 5769;
public override uint MessageId
{
    get { return Id; }
}



public ItemNoMoreAvailableMessage()
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