


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceModificationEmblemValidMessage : NetworkMessage
{

public const uint Id = 6447;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildEmblem Alliancemblem;
        

public AllianceModificationEmblemValidMessage()
{
}

public AllianceModificationEmblemValidMessage(Types.GuildEmblem Alliancemblem)
        {
            this.Alliancemblem = Alliancemblem;
        }
        

public override void Serialize(BigEndianWriter writer)
{

Alliancemblem.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

Alliancemblem = new Types.GuildEmblem();
            Alliancemblem.Deserialize(reader);
            

}


}


}