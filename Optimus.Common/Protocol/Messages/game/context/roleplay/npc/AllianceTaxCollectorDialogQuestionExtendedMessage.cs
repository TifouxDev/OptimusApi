


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceTaxCollectorDialogQuestionExtendedMessage : TaxCollectorDialogQuestionExtendedMessage
{

public const uint Id = 6445;
public override uint MessageId
{
    get { return Id; }
}

public Types.BasicNamedAllianceInformations alliance;
        

public AllianceTaxCollectorDialogQuestionExtendedMessage()
{
}

public AllianceTaxCollectorDialogQuestionExtendedMessage(Types.BasicGuildInformations guildInfo, short maxPods, short prospecting, short wisdom, sbyte taxCollectorsCount, int taxCollectorAttack, int kamas, double experience, int pods, int itemsValue, Types.BasicNamedAllianceInformations alliance)
         : base(guildInfo, maxPods, prospecting, wisdom, taxCollectorsCount, taxCollectorAttack, kamas, experience, pods, itemsValue)
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
            alliance = new Types.BasicNamedAllianceInformations();
            alliance.Deserialize(reader);
            

}


}


}