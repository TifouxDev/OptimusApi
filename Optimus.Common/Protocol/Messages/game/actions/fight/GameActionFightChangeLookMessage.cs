


















// Generated on 10/27/2013 07:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightChangeLookMessage : AbstractGameActionMessage
{

public const uint Id = 5532;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public Types.EntityLook entityLook;
        

public GameActionFightChangeLookMessage()
{
}

public GameActionFightChangeLookMessage(short actionId, int sourceId, int targetId, Types.EntityLook entityLook)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.entityLook = entityLook;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            entityLook.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
            

}


}


}