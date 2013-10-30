


















// Generated on 10/27/2013 07:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightLifeAndShieldPointsLostMessage : GameActionFightLifePointsLostMessage
{

public const uint Id = 6310;
public override uint MessageId
{
    get { return Id; }
}

public short shieldLoss;
        

public GameActionFightLifeAndShieldPointsLostMessage()
{
}

public GameActionFightLifeAndShieldPointsLostMessage(short actionId, int sourceId, int targetId, short loss, short permanentDamages, short shieldLoss)
         : base(actionId, sourceId, targetId, loss, permanentDamages)
        {
            this.shieldLoss = shieldLoss;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(shieldLoss);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            shieldLoss = reader.ReadShort();
            if (shieldLoss < 0)
                throw new Exception("Forbidden value on shieldLoss = " + shieldLoss + ", it doesn't respect the following condition : shieldLoss < 0");
            

}


}


}