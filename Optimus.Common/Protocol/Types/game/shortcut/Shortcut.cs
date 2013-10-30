


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class Shortcut
{

public const short Id = 369;
public virtual short TypeId
{
    get { return Id; }
}

public int slot;
        

public Shortcut()
{
}

public Shortcut(int slot)
        {
            this.slot = slot;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteInt(slot);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

slot = reader.ReadInt();
            if (slot < 0 || slot > 99)
                throw new Exception("Forbidden value on slot = " + slot + ", it doesn't respect the following condition : slot < 0 || slot > 99");
            

}


}


}