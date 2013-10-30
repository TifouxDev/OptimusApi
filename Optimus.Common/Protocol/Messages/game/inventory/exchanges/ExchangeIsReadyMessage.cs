


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeIsReadyMessage : NetworkMessage
{

public const uint Id = 5509;
public override uint MessageId
{
    get { return Id; }
}

public int id;
        public bool ready;
        

public ExchangeIsReadyMessage()
{
}

public ExchangeIsReadyMessage(int id, bool ready)
        {
            this.id = id;
            this.ready = ready;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(id);
            writer.WriteBoolean(ready);
            

}

public override void Deserialize(BigEndianReader reader)
{

id = reader.ReadInt();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            ready = reader.ReadBoolean();
            

}


}


}