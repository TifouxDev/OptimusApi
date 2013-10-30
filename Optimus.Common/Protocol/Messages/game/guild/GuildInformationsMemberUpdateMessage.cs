


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildInformationsMemberUpdateMessage : NetworkMessage
{

public const uint Id = 5597;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildMember member;
        

public GuildInformationsMemberUpdateMessage()
{
}

public GuildInformationsMemberUpdateMessage(Types.GuildMember member)
        {
            this.member = member;
        }
        

public override void Serialize(BigEndianWriter writer)
{

member.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

member = new Types.GuildMember();
            member.Deserialize(reader);
            

}


}


}