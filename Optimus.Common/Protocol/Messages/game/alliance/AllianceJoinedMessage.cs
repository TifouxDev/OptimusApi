


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceJoinedMessage : NetworkMessage
{

public const uint Id = 6402;
public override uint MessageId
{
    get { return Id; }
}

public Types.AllianceInformations allianceInfo;
        public bool enabled;
        

public AllianceJoinedMessage()
{
}

public AllianceJoinedMessage(Types.AllianceInformations allianceInfo, bool enabled)
        {
            this.allianceInfo = allianceInfo;
            this.enabled = enabled;
        }
        

public override void Serialize(BigEndianWriter writer)
{

allianceInfo.Serialize(writer);
            writer.WriteBoolean(enabled);
            

}

public override void Deserialize(BigEndianReader reader)
{

allianceInfo = new Types.AllianceInformations();
            allianceInfo.Deserialize(reader);
            enabled = reader.ReadBoolean();
            

}


}


}