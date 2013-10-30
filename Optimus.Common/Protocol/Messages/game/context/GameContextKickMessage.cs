


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameContextKickMessage : NetworkMessage
{

public const uint Id = 6081;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        

public GameContextKickMessage()
{
}

public GameContextKickMessage(int targetId)
        {
            this.targetId = targetId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(targetId);
            

}

public override void Deserialize(BigEndianReader reader)
{

targetId = reader.ReadInt();
            

}


}


}