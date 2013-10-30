


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class TaxCollectorStaticExtendedInformations : TaxCollectorStaticInformations
{

public const short Id = 440;
public override short TypeId
{
    get { return Id; }
}

public Types.AllianceInformations allianceIdentity;
        

public TaxCollectorStaticExtendedInformations()
{
}

public TaxCollectorStaticExtendedInformations(short firstNameId, short lastNameId, Types.GuildInformations guildIdentity, Types.AllianceInformations allianceIdentity)
         : base(firstNameId, lastNameId, guildIdentity)
        {
            this.allianceIdentity = allianceIdentity;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            allianceIdentity.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            allianceIdentity = new Types.AllianceInformations();
            allianceIdentity.Deserialize(reader);
            

}


}


}