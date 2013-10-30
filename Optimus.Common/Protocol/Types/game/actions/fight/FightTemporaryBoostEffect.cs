


















// Generated on 10/27/2013 07:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FightTemporaryBoostEffect : AbstractFightDispellableEffect
{

public const short Id = 209;
public override short TypeId
{
    get { return Id; }
}

public short delta;
        

public FightTemporaryBoostEffect()
{
}

public FightTemporaryBoostEffect(int uid, int targetId, short turnDuration, sbyte dispelable, short spellId, int parentBoostUid, short delta)
         : base(uid, targetId, turnDuration, dispelable, spellId, parentBoostUid)
        {
            this.delta = delta;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(delta);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            delta = reader.ReadShort();
            

}


}


}