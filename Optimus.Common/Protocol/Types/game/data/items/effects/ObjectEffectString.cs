


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ObjectEffectString : ObjectEffect
{

public const short Id = 74;
public override short TypeId
{
    get { return Id; }
}

public string value;
        

public ObjectEffectString()
{
}

public ObjectEffectString(short actionId, string value)
         : base(actionId)
        {
            this.value = value;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(value);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            value = reader.ReadUTF();
            

}


}


}