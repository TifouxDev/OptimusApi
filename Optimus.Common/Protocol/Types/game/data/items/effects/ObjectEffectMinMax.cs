


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ObjectEffectMinMax : ObjectEffect
{

public const short Id = 82;
public override short TypeId
{
    get { return Id; }
}

public short min;
        public short max;
        

public ObjectEffectMinMax()
{
}

public ObjectEffectMinMax(short actionId, short min, short max)
         : base(actionId)
        {
            this.min = min;
            this.max = max;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(min);
            writer.WriteShort(max);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            min = reader.ReadShort();
            if (min < 0)
                throw new Exception("Forbidden value on min = " + min + ", it doesn't respect the following condition : min < 0");
            max = reader.ReadShort();
            if (max < 0)
                throw new Exception("Forbidden value on max = " + max + ", it doesn't respect the following condition : max < 0");
            

}


}


}