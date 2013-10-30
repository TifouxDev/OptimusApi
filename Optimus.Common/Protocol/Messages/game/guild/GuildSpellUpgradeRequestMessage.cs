


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildSpellUpgradeRequestMessage : NetworkMessage
{

public const uint Id = 5699;
public override uint MessageId
{
    get { return Id; }
}

public int spellId;
        

public GuildSpellUpgradeRequestMessage()
{
}

public GuildSpellUpgradeRequestMessage(int spellId)
        {
            this.spellId = spellId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(spellId);
            

}

public override void Deserialize(BigEndianReader reader)
{

spellId = reader.ReadInt();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            

}


}


}