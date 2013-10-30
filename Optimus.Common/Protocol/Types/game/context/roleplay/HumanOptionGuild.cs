


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class HumanOptionGuild : HumanOption
{

public const short Id = 409;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildInformations guildInformations;
        

public HumanOptionGuild()
{
}

public HumanOptionGuild(Types.GuildInformations guildInformations)
        {
            this.guildInformations = guildInformations;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            guildInformations.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            guildInformations = new Types.GuildInformations();
            guildInformations.Deserialize(reader);
            

}


}


}