


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameRolePlayShowChallengeMessage : NetworkMessage
{

public const uint Id = 301;
public override uint MessageId
{
    get { return Id; }
}

public Types.FightCommonInformations commonsInfos;
        

public GameRolePlayShowChallengeMessage()
{
}

public GameRolePlayShowChallengeMessage(Types.FightCommonInformations commonsInfos)
        {
            this.commonsInfos = commonsInfos;
        }
        

public override void Serialize(BigEndianWriter writer)
{

commonsInfos.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

commonsInfos = new Types.FightCommonInformations();
            commonsInfos.Deserialize(reader);
            

}


}


}