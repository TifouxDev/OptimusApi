


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightTurnReadyMessage : NetworkMessage
{

public const uint Id = 716;
public override uint MessageId
{
    get { return Id; }
}

public bool isReady;
        

public GameFightTurnReadyMessage()
{
}

public GameFightTurnReadyMessage(bool isReady)
        {
            this.isReady = isReady;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(isReady);
            

}

public override void Deserialize(BigEndianReader reader)
{

isReady = reader.ReadBoolean();
            

}


}


}