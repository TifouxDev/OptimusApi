


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class EmotePlayErrorMessage : NetworkMessage
{

public const uint Id = 5688;
public override uint MessageId
{
    get { return Id; }
}

public sbyte emoteId;
        

public EmotePlayErrorMessage()
{
}

public EmotePlayErrorMessage(sbyte emoteId)
        {
            this.emoteId = emoteId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(emoteId);
            

}

public override void Deserialize(BigEndianReader reader)
{

emoteId = reader.ReadSByte();
            

}


}


}