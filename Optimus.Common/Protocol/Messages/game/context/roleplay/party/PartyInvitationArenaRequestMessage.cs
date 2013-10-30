


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyInvitationArenaRequestMessage : PartyInvitationRequestMessage
{

public const uint Id = 6283;
public override uint MessageId
{
    get { return Id; }
}



public PartyInvitationArenaRequestMessage()
{
}

public PartyInvitationArenaRequestMessage(string name)
         : base(name)
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