


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightTurnResumeMessage : GameFightTurnStartMessage
{

public const uint Id = 6307;
public override uint MessageId
{
    get { return Id; }
}



public GameFightTurnResumeMessage()
{
}

public GameFightTurnResumeMessage(int id, int waitTime)
         : base(id, waitTime)
        {
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            

}


}


}