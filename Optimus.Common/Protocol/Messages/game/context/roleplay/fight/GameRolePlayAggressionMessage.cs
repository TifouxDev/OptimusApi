


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameRolePlayAggressionMessage : NetworkMessage
{

public const uint Id = 6073;
public override uint MessageId
{
    get { return Id; }
}

public int attackerId;
        public int defenderId;
        

public GameRolePlayAggressionMessage()
{
}

public GameRolePlayAggressionMessage(int attackerId, int defenderId)
        {
            this.attackerId = attackerId;
            this.defenderId = defenderId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(attackerId);
            writer.WriteInt(defenderId);
            

}

public override void Deserialize(BigEndianReader reader)
{

attackerId = reader.ReadInt();
            if (attackerId < 0)
                throw new Exception("Forbidden value on attackerId = " + attackerId + ", it doesn't respect the following condition : attackerId < 0");
            defenderId = reader.ReadInt();
            if (defenderId < 0)
                throw new Exception("Forbidden value on defenderId = " + defenderId + ", it doesn't respect the following condition : defenderId < 0");
            

}


}


}