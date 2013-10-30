


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightShowFighterRandomStaticPoseMessage : GameFightShowFighterMessage
{

public const uint Id = 6218;
public override uint MessageId
{
    get { return Id; }
}



public GameFightShowFighterRandomStaticPoseMessage()
{
}

public GameFightShowFighterRandomStaticPoseMessage(Types.GameFightFighterInformations informations)
         : base(informations)
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