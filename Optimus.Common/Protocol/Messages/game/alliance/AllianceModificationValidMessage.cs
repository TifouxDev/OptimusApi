


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceModificationValidMessage : NetworkMessage
{

public const uint Id = 6450;
public override uint MessageId
{
    get { return Id; }
}

public string allianceName;
        public string allianceTag;
        public Types.GuildEmblem Alliancemblem;
        

public AllianceModificationValidMessage()
{
}

public AllianceModificationValidMessage(string allianceName, string allianceTag, Types.GuildEmblem Alliancemblem)
        {
            this.allianceName = allianceName;
            this.allianceTag = allianceTag;
            this.Alliancemblem = Alliancemblem;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(allianceName);
            writer.WriteUTF(allianceTag);
            Alliancemblem.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

allianceName = reader.ReadUTF();
            allianceTag = reader.ReadUTF();
            Alliancemblem = new Types.GuildEmblem();
            Alliancemblem.Deserialize(reader);
            

}


}


}