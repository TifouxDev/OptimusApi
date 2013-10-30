


















// Generated on 10/27/2013 07:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ServerSessionConstant
{

public const short Id = 430;
public virtual short TypeId
{
    get { return Id; }
}

public short id;
        

public ServerSessionConstant()
{
}

public ServerSessionConstant(short id)
        {
            this.id = id;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteShort(id);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

id = reader.ReadShort();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            

}


}


}