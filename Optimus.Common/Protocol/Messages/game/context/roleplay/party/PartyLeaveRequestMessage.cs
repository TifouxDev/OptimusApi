


















// Generated on 10/27/2013 07:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyLeaveRequestMessage : AbstractPartyMessage
{

public const uint Id = 5593;
public override uint MessageId
{
    get { return Id; }
}



public PartyLeaveRequestMessage()
{
}

public PartyLeaveRequestMessage(int partyId)
         : base(partyId)
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