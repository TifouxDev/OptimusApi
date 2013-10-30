


















// Generated on 10/27/2013 07:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyInvitationRequestMessage : NetworkMessage
{

public const uint Id = 5585;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        

public PartyInvitationRequestMessage()
{
}

public PartyInvitationRequestMessage(string name)
        {
            this.name = name;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(name);
            

}

public override void Deserialize(BigEndianReader reader)
{

name = reader.ReadUTF();
            

}


}


}