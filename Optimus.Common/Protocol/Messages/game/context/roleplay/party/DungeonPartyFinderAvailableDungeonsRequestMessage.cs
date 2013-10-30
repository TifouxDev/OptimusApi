


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class DungeonPartyFinderAvailableDungeonsRequestMessage : NetworkMessage
{

public const uint Id = 6240;
public override uint MessageId
{
    get { return Id; }
}



public DungeonPartyFinderAvailableDungeonsRequestMessage()
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