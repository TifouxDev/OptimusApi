


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ShortcutSmiley : Shortcut
{

public const short Id = 388;
public override short TypeId
{
    get { return Id; }
}

public sbyte smileyId;
        

public ShortcutSmiley()
{
}

public ShortcutSmiley(int slot, sbyte smileyId)
         : base(slot)
        {
            this.smileyId = smileyId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(smileyId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            smileyId = reader.ReadSByte();
            if (smileyId < 0)
                throw new Exception("Forbidden value on smileyId = " + smileyId + ", it doesn't respect the following condition : smileyId < 0");
            

}


}


}