


















// Generated on 10/27/2013 07:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FightTemporarySpellImmunityEffect : AbstractFightDispellableEffect
{

public const short Id = 366;
public override short TypeId
{
    get { return Id; }
}

public int immuneSpellId;
        

public FightTemporarySpellImmunityEffect()
{
}

public FightTemporarySpellImmunityEffect(int uid, int targetId, short turnDuration, sbyte dispelable, short spellId, int parentBoostUid, int immuneSpellId)
         : base(uid, targetId, turnDuration, dispelable, spellId, parentBoostUid)
        {
            this.immuneSpellId = immuneSpellId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(immuneSpellId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            immuneSpellId = reader.ReadInt();
            

}


}


}