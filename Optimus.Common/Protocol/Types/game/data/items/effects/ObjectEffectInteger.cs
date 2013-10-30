


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ObjectEffectInteger : ObjectEffect
{

public const short Id = 70;
public override short TypeId
{
    get { return Id; }
}

public short value;
        

public ObjectEffectInteger()
{
}

public ObjectEffectInteger(short actionId, short value)
         : base(actionId)
        {
            this.value = value;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(value);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            value = reader.ReadShort();
            if (value < 0)
                throw new Exception("Forbidden value on value = " + value + ", it doesn't respect the following condition : value < 0");
            

}


}


}