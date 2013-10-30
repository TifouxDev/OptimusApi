


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class AbstractCharacterInformation
{

public const short Id = 400;
public virtual short TypeId
{
    get { return Id; }
}

public int id;
        

public AbstractCharacterInformation()
{
}

public AbstractCharacterInformation(int id)
        {
            this.id = id;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteInt(id);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

id = reader.ReadInt();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            

}


}


}