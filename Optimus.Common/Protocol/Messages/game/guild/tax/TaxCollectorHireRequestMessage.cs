// Generated on 07/12/2013 12:13:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TaxCollectorHireRequestMessage : NetworkMessage
{

public const uint Id = 5681;
public override uint MessageId
{
    get { return Id; }
}



public TaxCollectorHireRequestMessage()
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