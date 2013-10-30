


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightNewRoundMessage : NetworkMessage
{

public const uint Id = 6239;
public override uint MessageId
{
    get { return Id; }
}

public int roundNumber;
        

public GameFightNewRoundMessage()
{
}

public GameFightNewRoundMessage(int roundNumber)
        {
            this.roundNumber = roundNumber;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(roundNumber);
            

}

public override void Deserialize(BigEndianReader reader)
{

roundNumber = reader.ReadInt();
            if (roundNumber < 0)
                throw new Exception("Forbidden value on roundNumber = " + roundNumber + ", it doesn't respect the following condition : roundNumber < 0");
            

}


}


}