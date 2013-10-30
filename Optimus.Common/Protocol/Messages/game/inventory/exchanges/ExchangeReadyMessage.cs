


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeReadyMessage : NetworkMessage
{

public const uint Id = 5511;
public override uint MessageId
{
    get { return Id; }
}

public bool ready;
        public short step;
        

public ExchangeReadyMessage()
{
}

public ExchangeReadyMessage(bool ready, short step)
        {
            this.ready = ready;
            this.step = step;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(ready);
            writer.WriteShort(step);
            

}

public override void Deserialize(BigEndianReader reader)
{

ready = reader.ReadBoolean();
            step = reader.ReadShort();
            if (step < 0)
                throw new Exception("Forbidden value on step = " + step + ", it doesn't respect the following condition : step < 0");
            

}


}


}