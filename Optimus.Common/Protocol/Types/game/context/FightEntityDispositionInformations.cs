


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FightEntityDispositionInformations : EntityDispositionInformations
{

public const short Id = 217;
public override short TypeId
{
    get { return Id; }
}

public int carryingCharacterId;
        

public FightEntityDispositionInformations()
{
}

public FightEntityDispositionInformations(short cellId, sbyte direction, int carryingCharacterId)
         : base(cellId, direction)
        {
            this.carryingCharacterId = carryingCharacterId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(carryingCharacterId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            carryingCharacterId = reader.ReadInt();
            

}


}


}