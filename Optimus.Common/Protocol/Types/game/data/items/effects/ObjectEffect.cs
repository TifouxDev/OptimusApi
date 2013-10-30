


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ObjectEffect
{

public const short Id = 76;
public virtual short TypeId
{
    get { return Id; }
}

public short actionId;
        

public ObjectEffect()
{
}

public ObjectEffect(short actionId)
        {
            this.actionId = actionId;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteShort(actionId);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

actionId = reader.ReadShort();
            if (actionId < 0)
                throw new Exception("Forbidden value on actionId = " + actionId + ", it doesn't respect the following condition : actionId < 0");
            

}


}


}