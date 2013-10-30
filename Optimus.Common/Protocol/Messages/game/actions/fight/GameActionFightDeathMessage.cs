


















// Generated on 10/27/2013 07:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightDeathMessage : AbstractGameActionMessage
{

public const uint Id = 1099;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        

public GameActionFightDeathMessage()
{
}

public GameActionFightDeathMessage(short actionId, int sourceId, int targetId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            

}


}


}