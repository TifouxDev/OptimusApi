


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameContextRemoveElementMessage : NetworkMessage
{

public const uint Id = 251;
public override uint MessageId
{
    get { return Id; }
}

public int id;
        

public GameContextRemoveElementMessage()
{
}

public GameContextRemoveElementMessage(int id)
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