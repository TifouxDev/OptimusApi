


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeReplayMessage : NetworkMessage
{

public const uint Id = 6002;
public override uint MessageId
{
    get { return Id; }
}

public int count;
        

public ExchangeReplayMessage()
{
}

public ExchangeReplayMessage(int count)
        {
            this.count = count;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(count);
            

}

public override void Deserialize(BigEndianReader reader)
{

count = reader.ReadInt();
            

}


}


}