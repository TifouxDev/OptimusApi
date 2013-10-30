


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class IdentifiedEntityDispositionInformations : EntityDispositionInformations
{

public const short Id = 107;
public override short TypeId
{
    get { return Id; }
}

public int id;
        

public IdentifiedEntityDispositionInformations()
{
}

public IdentifiedEntityDispositionInformations(short cellId, sbyte direction, int id)
         : base(cellId, direction)
        {
            this.id = id;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(id);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            id = reader.ReadInt();
            

}


}


}