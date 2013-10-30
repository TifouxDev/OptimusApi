


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightLeaveMessage : NetworkMessage
{

public const uint Id = 721;
public override uint MessageId
{
    get { return Id; }
}

public int charId;
        

public GameFightLeaveMessage()
{
}

public GameFightLeaveMessage(int charId)
        {
            this.charId = charId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(charId);
            

}

public override void Deserialize(BigEndianReader reader)
{

charId = reader.ReadInt();
            

}


}


}