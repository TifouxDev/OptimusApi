


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildFightLeaveRequestMessage : NetworkMessage
{

public const uint Id = 5715;
public override uint MessageId
{
    get { return Id; }
}

public int taxCollectorId;
        public int characterId;
        

public GuildFightLeaveRequestMessage()
{
}

public GuildFightLeaveRequestMessage(int taxCollectorId, int characterId)
        {
            this.taxCollectorId = taxCollectorId;
            this.characterId = characterId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(taxCollectorId);
            writer.WriteInt(characterId);
            

}

public override void Deserialize(BigEndianReader reader)
{

taxCollectorId = reader.ReadInt();
            characterId = reader.ReadInt();
            if (characterId < 0)
                throw new Exception("Forbidden value on characterId = " + characterId + ", it doesn't respect the following condition : characterId < 0");
            

}


}


}