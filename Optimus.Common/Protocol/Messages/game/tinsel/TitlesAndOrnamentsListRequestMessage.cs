


















// Generated on 10/27/2013 07:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TitlesAndOrnamentsListRequestMessage : NetworkMessage
{

public const uint Id = 6363;
public override uint MessageId
{
    get { return Id; }
}



public TitlesAndOrnamentsListRequestMessage()
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