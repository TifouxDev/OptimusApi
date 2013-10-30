


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameRolePlayShowActorWithEventMessage : GameRolePlayShowActorMessage
{

public const uint Id = 6407;
public override uint MessageId
{
    get { return Id; }
}

public sbyte actorEventId;
        

public GameRolePlayShowActorWithEventMessage()
{
}

public GameRolePlayShowActorWithEventMessage(Types.GameRolePlayActorInformations informations, sbyte actorEventId)
         : base(informations)
        {
            this.actorEventId = actorEventId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(actorEventId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            actorEventId = reader.ReadSByte();
            if (actorEventId < 0)
                throw new Exception("Forbidden value on actorEventId = " + actorEventId + ", it doesn't respect the following condition : actorEventId < 0");
            

}


}


}