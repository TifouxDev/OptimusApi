


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class UpdateMountIntBoost : UpdateMountBoost
{

public const short Id = 357;
public override short TypeId
{
    get { return Id; }
}

public int value;
        

public UpdateMountIntBoost()
{
}

public UpdateMountIntBoost(sbyte type, int value)
         : base(type)
        {
            this.value = value;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(value);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            value = reader.ReadInt();
            

}


}


}