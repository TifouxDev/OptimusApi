


















// Generated on 10/27/2013 07:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FightTemporaryBoostStateEffect : FightTemporaryBoostEffect
{

public const short Id = 214;
public override short TypeId
{
    get { return Id; }
}

public short stateId;
        

public FightTemporaryBoostStateEffect()
{
}

public FightTemporaryBoostStateEffect(int uid, int targetId, short turnDuration, sbyte dispelable, short spellId, int parentBoostUid, short delta, short stateId)
         : base(uid, targetId, turnDuration, dispelable, spellId, parentBoostUid, delta)
        {
            this.stateId = stateId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(stateId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            stateId = reader.ReadShort();
            

}


}


}