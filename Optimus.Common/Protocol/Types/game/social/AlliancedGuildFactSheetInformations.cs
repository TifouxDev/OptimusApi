


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class AlliancedGuildFactSheetInformations : GuildInformations
{

public const short Id = 422;
public override short TypeId
{
    get { return Id; }
}

public Types.BasicNamedAllianceInformations allianceInfos;
        

public AlliancedGuildFactSheetInformations()
{
}

public AlliancedGuildFactSheetInformations(int guildId, string guildName, Types.GuildEmblem guildEmblem, Types.BasicNamedAllianceInformations allianceInfos)
         : base(guildId, guildName, guildEmblem)
        {
            this.allianceInfos = allianceInfos;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            allianceInfos.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            allianceInfos = new Types.BasicNamedAllianceInformations();
            allianceInfos.Deserialize(reader);
            

}


}


}