


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class PaddockPrivateInformations : PaddockAbandonnedInformations
{

public const short Id = 131;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildInformations guildInfo;
        

public PaddockPrivateInformations()
{
}

public PaddockPrivateInformations(short maxOutdoorMount, short maxItems, int price, bool locked, int guildId, Types.GuildInformations guildInfo)
         : base(maxOutdoorMount, maxItems, price, locked, guildId)
        {
            this.guildInfo = guildInfo;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            guildInfo.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            

}


}


}