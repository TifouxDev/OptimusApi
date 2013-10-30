


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildModificationNameValidMessage : NetworkMessage
{

public const uint Id = 6327;
public override uint MessageId
{
    get { return Id; }
}

public string guildName;
        

public GuildModificationNameValidMessage()
{
}

public GuildModificationNameValidMessage(string guildName)
        {
            this.guildName = guildName;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(guildName);
            

}

public override void Deserialize(BigEndianReader reader)
{

guildName = reader.ReadUTF();
            

}


}


}