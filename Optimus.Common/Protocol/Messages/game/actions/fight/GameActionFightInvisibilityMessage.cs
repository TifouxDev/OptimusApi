


















// Generated on 10/27/2013 07:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightInvisibilityMessage : AbstractGameActionMessage
{

public const uint Id = 5821;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public sbyte state;
        

public GameActionFightInvisibilityMessage()
{
}

public GameActionFightInvisibilityMessage(short actionId, int sourceId, int targetId, sbyte state)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.state = state;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteSByte(state);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            state = reader.ReadSByte();
            

}


}


}