


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class StopToListenRunningFightRequestMessage : NetworkMessage
{

public const uint Id = 6124;
public override uint MessageId
{
    get { return Id; }
}



public StopToListenRunningFightRequestMessage()
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