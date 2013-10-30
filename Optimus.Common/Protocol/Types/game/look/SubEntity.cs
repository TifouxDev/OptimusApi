


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class SubEntity
{

public const short Id = 54;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte bindingPointCategory;
        public sbyte bindingPointIndex;
        public Types.EntityLook subEntityLook;
        

public SubEntity()
{
}

public SubEntity(sbyte bindingPointCategory, sbyte bindingPointIndex, Types.EntityLook subEntityLook)
        {
            this.bindingPointCategory = bindingPointCategory;
            this.bindingPointIndex = bindingPointIndex;
            this.subEntityLook = subEntityLook;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(bindingPointCategory);
            writer.WriteSByte(bindingPointIndex);
            subEntityLook.Serialize(writer);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

bindingPointCategory = reader.ReadSByte();
            if (bindingPointCategory < 0)
                throw new Exception("Forbidden value on bindingPointCategory = " + bindingPointCategory + ", it doesn't respect the following condition : bindingPointCategory < 0");
            bindingPointIndex = reader.ReadSByte();
            if (bindingPointIndex < 0)
                throw new Exception("Forbidden value on bindingPointIndex = " + bindingPointIndex + ", it doesn't respect the following condition : bindingPointIndex < 0");
            subEntityLook = new Types.EntityLook();
            subEntityLook.Deserialize(reader);
            

}


}


}