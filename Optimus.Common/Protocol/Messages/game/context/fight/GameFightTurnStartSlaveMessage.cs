


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightTurnStartSlaveMessage : GameFightTurnStartMessage
{

public const uint Id = 6213;
public override uint MessageId
{
    get { return Id; }
}

public int idSummoner;
        

public GameFightTurnStartSlaveMessage()
{
}

public GameFightTurnStartSlaveMessage(int id, int waitTime, int idSummoner)
         : base(id, waitTime)
        {
            this.idSummoner = idSummoner;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(idSummoner);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            idSummoner = reader.ReadInt();
            

}


}


}