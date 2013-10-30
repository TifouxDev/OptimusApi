


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AuthenticationTicketMessage : NetworkMessage
{

public const uint Id = 110;
public override uint MessageId
{
    get { return Id; }
}

public string lang;
        public string ticket;
        

public AuthenticationTicketMessage()
{
}

public AuthenticationTicketMessage(string lang, string ticket)
        {
            this.lang = lang;
            this.ticket = ticket;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(lang);
            writer.WriteUTF(ticket);
            

}

public override void Deserialize(BigEndianReader reader)
{

lang = reader.ReadUTF();
            ticket = reader.ReadUTF();
            

}


}


}