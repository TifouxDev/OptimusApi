


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ShortcutEmote : Shortcut
{

public const short Id = 389;
public override short TypeId
{
    get { return Id; }
}

public sbyte emoteId;
        

public ShortcutEmote()
{
}

public ShortcutEmote(int slot, sbyte emoteId)
         : base(slot)
        {
            this.emoteId = emoteId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(emoteId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            emoteId = reader.ReadSByte();
            if (emoteId < 0)
                throw new Exception("Forbidden value on emoteId = " + emoteId + ", it doesn't respect the following condition : emoteId < 0");
            

}


}


}