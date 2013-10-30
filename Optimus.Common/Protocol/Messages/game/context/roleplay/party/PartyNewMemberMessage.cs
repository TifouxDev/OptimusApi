


















// Generated on 10/27/2013 07:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyNewMemberMessage : PartyUpdateMessage
{

public const uint Id = 6306;
public override uint MessageId
{
    get { return Id; }
}



public PartyNewMemberMessage()
{
}

public PartyNewMemberMessage(int partyId, Types.PartyMemberInformations memberInformations)
         : base(partyId, memberInformations)
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