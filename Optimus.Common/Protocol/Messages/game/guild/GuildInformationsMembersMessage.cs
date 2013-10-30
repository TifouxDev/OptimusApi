


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildInformationsMembersMessage : NetworkMessage
{

public const uint Id = 5558;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildMember[] members;
        

public GuildInformationsMembersMessage()
{
}

public GuildInformationsMembersMessage(Types.GuildMember[] members)
        {
            this.members = members;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)members.Length);
            foreach (var entry in members)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            members = new Types.GuildMember[limit];
            for (int i = 0; i < limit; i++)
            {
                 members[i] = new Types.GuildMember();
                 members[i].Deserialize(reader);
            }
            

}


}


}