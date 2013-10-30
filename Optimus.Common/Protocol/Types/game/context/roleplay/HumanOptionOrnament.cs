


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class HumanOptionOrnament : HumanOption
{

public const short Id = 411;
public override short TypeId
{
    get { return Id; }
}

public short ornamentId;
        

public HumanOptionOrnament()
{
}

public HumanOptionOrnament(short ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(ornamentId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            ornamentId = reader.ReadShort();
            if (ornamentId < 0)
                throw new Exception("Forbidden value on ornamentId = " + ornamentId + ", it doesn't respect the following condition : ornamentId < 0");
            

}


}


}