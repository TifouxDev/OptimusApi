


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceCreationValidMessage : NetworkMessage
{

public const uint Id = 6393;
public override uint MessageId
{
    get { return Id; }
}

public string allianceName;
        public string allianceTag;
        public Types.GuildEmblem allianceEmblem;
        

public AllianceCreationValidMessage()
{
}

public AllianceCreationValidMessage(string allianceName, string allianceTag, Types.GuildEmblem allianceEmblem)
        {
            this.allianceName = allianceName;
            this.allianceTag = allianceTag;
            this.allianceEmblem = allianceEmblem;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(allianceName);
            writer.WriteUTF(allianceTag);
            allianceEmblem.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

allianceName = reader.ReadUTF();
            allianceTag = reader.ReadUTF();
            allianceEmblem = new Types.GuildEmblem();
            allianceEmblem.Deserialize(reader);
            

}


}


}