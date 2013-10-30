


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class HouseInformationsExtended : HouseInformations
{

public const short Id = 112;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildInformations guildInfo;
        

public HouseInformationsExtended()
{
}

public HouseInformationsExtended(bool isOnSale, bool isSaleLocked, int houseId, int[] doorsOnMap, string ownerName, short modelId, Types.GuildInformations guildInfo)
         : base(isOnSale, isSaleLocked, houseId, doorsOnMap, ownerName, modelId)
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