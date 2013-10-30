


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightModifyEffectsDurationMessage : AbstractGameActionMessage
{

public const uint Id = 6304;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public short delta;
        

public GameActionFightModifyEffectsDurationMessage()
{
}

public GameActionFightModifyEffectsDurationMessage(short actionId, int sourceId, int targetId, short delta)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.delta = delta;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteShort(delta);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            delta = reader.ReadShort();
            

}


}


}