


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildVersatileInfoListMessage : NetworkMessage
{

public const uint Id = 6435;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildVersatileInformations[] guilds;
        

public GuildVersatileInfoListMessage()
{
}

public GuildVersatileInfoListMessage(Types.GuildVersatileInformations[] guilds)
        {
            this.guilds = guilds;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)guilds.Length);
            foreach (var entry in guilds)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            guilds = new Types.GuildVersatileInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guilds[i] = Types.ProtocolTypeManager.GetInstance<Types.GuildVersatileInformations>(reader.ReadShort());
                 guilds[i].Deserialize(reader);
            }
            

}


}


}