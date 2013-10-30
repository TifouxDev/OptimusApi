


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TaxCollectorAttackedResultMessage : NetworkMessage
{

public const uint Id = 5635;
public override uint MessageId
{
    get { return Id; }
}

public bool deadOrAlive;
        public Types.TaxCollectorBasicInformations basicInfos;
        public Types.BasicGuildInformations guild;
        

public TaxCollectorAttackedResultMessage()
{
}

public TaxCollectorAttackedResultMessage(bool deadOrAlive, Types.TaxCollectorBasicInformations basicInfos, Types.BasicGuildInformations guild)
        {
            this.deadOrAlive = deadOrAlive;
            this.basicInfos = basicInfos;
            this.guild = guild;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(deadOrAlive);
            basicInfos.Serialize(writer);
            guild.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

deadOrAlive = reader.ReadBoolean();
            basicInfos = new Types.TaxCollectorBasicInformations();
            basicInfos.Deserialize(reader);
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
            

}


}


}