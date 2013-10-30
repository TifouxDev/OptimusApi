


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameContextMoveElementMessage : NetworkMessage
{

public const uint Id = 253;
public override uint MessageId
{
    get { return Id; }
}

public Types.EntityMovementInformations movement;
        

public GameContextMoveElementMessage()
{
}

public GameContextMoveElementMessage(Types.EntityMovementInformations movement)
        {
            this.movement = movement;
        }
        

public override void Serialize(BigEndianWriter writer)
{

movement.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

movement = new Types.EntityMovementInformations();
            movement.Deserialize(reader);
            

}


}


}