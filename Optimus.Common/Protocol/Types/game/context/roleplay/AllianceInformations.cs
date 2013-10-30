


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class AllianceInformations : BasicNamedAllianceInformations
{

public const short Id = 417;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildEmblem allianceEmblem;
        

public AllianceInformations()
{
}

public AllianceInformations(int allianceId, string allianceTag, string allianceName, Types.GuildEmblem allianceEmblem)
         : base(allianceId, allianceTag, allianceName)
        {
            this.allianceEmblem = allianceEmblem;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            allianceEmblem.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            allianceEmblem = new Types.GuildEmblem();
            allianceEmblem.Deserialize(reader);
            

}


}


}