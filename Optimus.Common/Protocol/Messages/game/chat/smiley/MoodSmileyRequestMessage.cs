


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MoodSmileyRequestMessage : NetworkMessage
{

public const uint Id = 6192;
public override uint MessageId
{
    get { return Id; }
}

public sbyte smileyId;
        

public MoodSmileyRequestMessage()
{
}

public MoodSmileyRequestMessage(sbyte smileyId)
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
            

}


}


}