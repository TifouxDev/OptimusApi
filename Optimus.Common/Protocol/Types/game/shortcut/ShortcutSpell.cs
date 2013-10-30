


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ShortcutSpell : Shortcut
{

public const short Id = 368;
public override short TypeId
{
    get { return Id; }
}

public short spellId;
        

public ShortcutSpell()
{
}

public ShortcutSpell(int slot, short spellId)
         : base(slot)
        {
            this.spellId = spellId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(spellId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            spellId = reader.ReadShort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            

}


}


}