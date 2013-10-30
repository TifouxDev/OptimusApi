


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class IndexedEntityLook
{

public const short Id = 405;
public virtual short TypeId
{
    get { return Id; }
}

public Types.EntityLook look;
        public sbyte index;
        

public IndexedEntityLook()
{
}

public IndexedEntityLook(Types.EntityLook look, sbyte index)
        {
            this.look = look;
            this.index = index;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

look.Serialize(writer);
            writer.WriteSByte(index);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

look = new Types.EntityLook();
            look.Deserialize(reader);
            index = reader.ReadSByte();
            if (index < 0)
                throw new Exception("Forbidden value on index = " + index + ", it doesn't respect the following condition : index < 0");
            

}


}


}