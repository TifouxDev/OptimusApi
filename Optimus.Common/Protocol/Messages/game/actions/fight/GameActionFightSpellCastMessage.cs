


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightSpellCastMessage : AbstractGameActionFightTargetedAbilityMessage
{

public const uint Id = 1010;
public override uint MessageId
{
    get { return Id; }
}

public short spellId;
        public sbyte spellLevel;
        

public GameActionFightSpellCastMessage()
{
}

public GameActionFightSpellCastMessage(short actionId, int sourceId, int targetId, short destinationCellId, sbyte critical, bool silentCast, short spellId, sbyte spellLevel)
         : base(actionId, sourceId, targetId, destinationCellId, critical, silentCast)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(spellId);
            writer.WriteSByte(spellLevel);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            spellId = reader.ReadShort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            spellLevel = reader.ReadSByte();
            if (spellLevel < 1 || spellLevel > 6)
                throw new Exception("Forbidden value on spellLevel = " + spellLevel + ", it doesn't respect the following condition : spellLevel < 1 || spellLevel > 6");
            

}


}


}