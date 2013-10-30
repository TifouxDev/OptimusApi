


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightTurnEndMessage : NetworkMessage
{

public const uint Id = 719;
public override uint MessageId
{
    get { return Id; }
}

public int id;
        

public GameFightTurnEndMessage()
{
}

public GameFightTurnEndMessage(int id)
        {
            this.id = id;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(id);
            

}

public override void Deserialize(BigEndianReader reader)
{

id = reader.ReadInt();
            

}


}


}