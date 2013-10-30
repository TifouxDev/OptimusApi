


















// Generated on 10/27/2013 07:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class SpellUpgradeRequestMessage : NetworkMessage
{

public const uint Id = 5608;
public override uint MessageId
{
    get { return Id; }
}

public short spellId;
        public sbyte spellLevel;
        

public SpellUpgradeRequestMessage()
{
}

public SpellUpgradeRequestMessage(short spellId, sbyte spellLevel)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(spellId);
            writer.WriteSByte(spellLevel);
            

}

public override void Deserialize(BigEndianReader reader)
{

spellId = reader.ReadShort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            spellLevel = reader.ReadSByte();
            if (spellLevel < 1 || spellLevel > 6)
                throw new Exception("Forbidden value on spellLevel = " + spellLevel + ", it doesn't respect the following condition : spellLevel < 1 || spellLevel > 6");
            

}


}


}