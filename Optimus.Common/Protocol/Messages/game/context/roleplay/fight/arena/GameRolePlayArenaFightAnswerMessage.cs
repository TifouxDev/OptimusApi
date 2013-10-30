


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameRolePlayArenaFightAnswerMessage : NetworkMessage
{

public const uint Id = 6279;
public override uint MessageId
{
    get { return Id; }
}

public int fightId;
        public bool accept;
        

public GameRolePlayArenaFightAnswerMessage()
{
}

public GameRolePlayArenaFightAnswerMessage(int fightId, bool accept)
        {
            this.fightId = fightId;
            this.accept = accept;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteBoolean(accept);
            

}

public override void Deserialize(BigEndianReader reader)
{

fightId = reader.ReadInt();
            accept = reader.ReadBoolean();
            

}


}


}