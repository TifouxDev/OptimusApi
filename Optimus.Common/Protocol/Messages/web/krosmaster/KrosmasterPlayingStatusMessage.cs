


















// Generated on 10/27/2013 07:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class KrosmasterPlayingStatusMessage : NetworkMessage
{

public const uint Id = 6347;
public override uint MessageId
{
    get { return Id; }
}

public bool playing;
        

public KrosmasterPlayingStatusMessage()
{
}

public KrosmasterPlayingStatusMessage(bool playing)
        {
            this.playing = playing;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(playing);
            

}

public override void Deserialize(BigEndianReader reader)
{

playing = reader.ReadBoolean();
            

}


}


}