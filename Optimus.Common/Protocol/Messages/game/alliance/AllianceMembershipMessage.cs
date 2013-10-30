


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceMembershipMessage : AllianceJoinedMessage
{

public const uint Id = 6390;
public override uint MessageId
{
    get { return Id; }
}



public AllianceMembershipMessage()
{
}

public AllianceMembershipMessage(Types.AllianceInformations allianceInfo, bool enabled)
         : base(allianceInfo, enabled)
        {
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            

}


}


}