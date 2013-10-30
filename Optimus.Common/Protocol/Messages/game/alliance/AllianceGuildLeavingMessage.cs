


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceGuildLeavingMessage : NetworkMessage
{

public const uint Id = 6399;
public override uint MessageId
{
    get { return Id; }
}

public bool kicked;
        public int guildId;
        

public AllianceGuildLeavingMessage()
{
}

public AllianceGuildLeavingMessage(bool kicked, int guildId)
        {
            this.kicked = kicked;
            this.guildId = guildId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(kicked);
            writer.WriteInt(guildId);
            

}

public override void Deserialize(BigEndianReader reader)
{

kicked = reader.ReadBoolean();
            guildId = reader.ReadInt();
            

}


}


}