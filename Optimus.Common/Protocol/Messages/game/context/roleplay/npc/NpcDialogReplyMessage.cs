


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class NpcDialogReplyMessage : NetworkMessage
{

public const uint Id = 5616;
public override uint MessageId
{
    get { return Id; }
}

public short replyId;
        

public NpcDialogReplyMessage()
{
}

public NpcDialogReplyMessage(short replyId)
        {
            this.replyId = replyId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(replyId);
            

}

public override void Deserialize(BigEndianReader reader)
{

replyId = reader.ReadShort();
            if (replyId < 0)
                throw new Exception("Forbidden value on replyId = " + replyId + ", it doesn't respect the following condition : replyId < 0");
            

}


}


}