


















// Generated on 10/27/2013 07:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionAcknowledgementMessage : NetworkMessage
{

public const uint Id = 957;
public override uint MessageId
{
    get { return Id; }
}

public bool valid;
        public sbyte actionId;
        

public GameActionAcknowledgementMessage()
{
}

public GameActionAcknowledgementMessage(bool valid, sbyte actionId)
        {
            this.valid = valid;
            this.actionId = actionId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(valid);
            writer.WriteSByte(actionId);
            

}

public override void Deserialize(BigEndianReader reader)
{

valid = reader.ReadBoolean();
            actionId = reader.ReadSByte();
            

}


}


}