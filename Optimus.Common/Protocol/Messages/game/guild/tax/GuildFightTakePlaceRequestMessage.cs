


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildFightTakePlaceRequestMessage : GuildFightJoinRequestMessage
{

public const uint Id = 6235;
public override uint MessageId
{
    get { return Id; }
}

public int replacedCharacterId;
        

public GuildFightTakePlaceRequestMessage()
{
}

public GuildFightTakePlaceRequestMessage(int taxCollectorId, int replacedCharacterId)
         : base(taxCollectorId)
        {
            this.replacedCharacterId = replacedCharacterId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(replacedCharacterId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            replacedCharacterId = reader.ReadInt();
            

}


}


}