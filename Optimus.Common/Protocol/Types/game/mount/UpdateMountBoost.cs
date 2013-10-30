


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class UpdateMountBoost
{

public const short Id = 356;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte type;
        

public UpdateMountBoost()
{
}

public UpdateMountBoost(sbyte type)
        {
            this.type = type;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(type);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

type = reader.ReadSByte();
            

}


}


}