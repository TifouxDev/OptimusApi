


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ChatSmileyRequestMessage : NetworkMessage
{

public const uint Id = 800;
public override uint MessageId
{
    get { return Id; }
}

public sbyte smileyId;
        

public ChatSmileyRequestMessage()
{
}

public ChatSmileyRequestMessage(sbyte smileyId)
        {
            this.smileyId = smileyId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(smileyId);
            

}

public override void Deserialize(BigEndianReader reader)
{

smileyId = reader.ReadSByte();
            if (smileyId < 0)
                throw new Exception("Forbidden value on smileyId = " + smileyId + ", it doesn't respect the following condition : smileyId < 0");
            

}


}


}