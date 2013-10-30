


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class LifePointsRegenEndMessage : UpdateLifePointsMessage
{

public const uint Id = 5686;
public override uint MessageId
{
    get { return Id; }
}

public int lifePointsGained;
        

public LifePointsRegenEndMessage()
{
}

public LifePointsRegenEndMessage(int lifePoints, int maxLifePoints, int lifePointsGained)
         : base(lifePoints, maxLifePoints)
        {
            this.lifePointsGained = lifePointsGained;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(lifePointsGained);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            lifePointsGained = reader.ReadInt();
            if (lifePointsGained < 0)
                throw new Exception("Forbidden value on lifePointsGained = " + lifePointsGained + ", it doesn't respect the following condition : lifePointsGained < 0");
            

}


}


}