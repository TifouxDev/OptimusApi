


















// Generated on 10/27/2013 07:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AbstractGameActionWithAckMessage : AbstractGameActionMessage
{

public const uint Id = 1001;
public override uint MessageId
{
    get { return Id; }
}

public short waitAckId;
        

public AbstractGameActionWithAckMessage()
{
}

public AbstractGameActionWithAckMessage(short actionId, int sourceId, short waitAckId)
         : base(actionId, sourceId)
        {
            this.waitAckId = waitAckId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(waitAckId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            waitAckId = reader.ReadShort();
            

}


}


}