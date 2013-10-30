


















// Generated on 10/27/2013 07:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FightTemporaryBoostWeaponDamagesEffect : FightTemporaryBoostEffect
{

public const short Id = 211;
public override short TypeId
{
    get { return Id; }
}

public short weaponTypeId;
        

public FightTemporaryBoostWeaponDamagesEffect()
{
}

public FightTemporaryBoostWeaponDamagesEffect(int uid, int targetId, short turnDuration, sbyte dispelable, short spellId, int parentBoostUid, short delta, short weaponTypeId)
         : base(uid, targetId, turnDuration, dispelable, spellId, parentBoostUid, delta)
        {
            this.weaponTypeId = weaponTypeId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(weaponTypeId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            weaponTypeId = reader.ReadShort();
            

}


}


}