


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameRolePlayRemoveChallengeMessage : NetworkMessage
{

public const uint Id = 300;
public override uint MessageId
{
    get { return Id; }
}

public int fightId;
        

public GameRolePlayRemoveChallengeMessage()
{
}

public GameRolePlayRemoveChallengeMessage(int fightId)
        {
            this.fightId = fightId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(fightId);
            

}

public override void Deserialize(BigEndianReader reader)
{

fightId = reader.ReadInt();
            

}


}


}