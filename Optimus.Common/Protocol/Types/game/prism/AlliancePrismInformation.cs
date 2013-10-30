


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class AlliancePrismInformation : PrismInformation
{

public const short Id = 427;
public override short TypeId
{
    get { return Id; }
}

public Types.AllianceInformations alliance;
        

public AlliancePrismInformation()
{
}

public AlliancePrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, int rewardTokenCount, Types.AllianceInformations alliance)
         : base(typeId, state, nextVulnerabilityDate, placementDate, rewardTokenCount)
        {
            this.alliance = alliance;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            alliance.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            alliance = new Types.AllianceInformations();
            alliance.Deserialize(reader);
            

}


}


}