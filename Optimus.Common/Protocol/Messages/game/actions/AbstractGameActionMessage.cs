


















// Generated on 10/27/2013 07:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AbstractGameActionMessage : NetworkMessage
{

public const uint Id = 1000;
public override uint MessageId
{
    get { return Id; }
}

public short actionId;
        public int sourceId;
        

public AbstractGameActionMessage()
{
}

public AbstractGameActionMessage(short actionId, int sourceId)
        {
            this.actionId = actionId;
            this.sourceId = sourceId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(actionId);
            writer.WriteInt(sourceId);
            

}

public override void Deserialize(BigEndianReader reader)
{

actionId = reader.ReadShort();
            if (actionId < 0)
                throw new Exception("Forbidden value on actionId = " + actionId + ", it doesn't respect the following condition : actionId < 0");
            sourceId = reader.ReadInt();
            

}


}


}