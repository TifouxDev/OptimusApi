


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class GameFightSpellCooldown
{

public const short Id = 205;
public virtual short TypeId
{
    get { return Id; }
}

public int spellId;
        public sbyte cooldown;
        

public GameFightSpellCooldown()
{
}

public GameFightSpellCooldown(int spellId, sbyte cooldown)
        {
            this.spellId = spellId;
            this.cooldown = cooldown;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteInt(spellId);
            writer.WriteSByte(cooldown);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

spellId = reader.ReadInt();
            cooldown = reader.ReadSByte();
            if (cooldown < 0)
                throw new Exception("Forbidden value on cooldown = " + cooldown + ", it doesn't respect the following condition : cooldown < 0");
            

}


}


}