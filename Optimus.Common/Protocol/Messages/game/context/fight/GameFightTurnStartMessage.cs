


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightTurnStartMessage : NetworkMessage
{

public const uint Id = 714;
public override uint MessageId
{
    get { return Id; }
}

public int id;
        public int waitTime;
        

public GameFightTurnStartMessage()
{
}

public GameFightTurnStartMessage(int id, int waitTime)
        {
            this.id = id;
            this.waitTime = waitTime;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(id);
            writer.WriteInt(waitTime);
            

}

public override void Deserialize(BigEndianReader reader)
{

id = reader.ReadInt();
            waitTime = reader.ReadInt();
            if (waitTime < 0)
                throw new Exception("Forbidden value on waitTime = " + waitTime + ", it doesn't respect the following condition : waitTime < 0");
            

}


}


}