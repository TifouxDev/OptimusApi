


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeItemAutoCraftRemainingMessage : NetworkMessage
{

public const uint Id = 6015;
public override uint MessageId
{
    get { return Id; }
}

public int count;
        

public ExchangeItemAutoCraftRemainingMessage()
{
}

public ExchangeItemAutoCraftRemainingMessage(int count)
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
            if (count < 0)
                throw new Exception("Forbidden value on count = " + count + ", it doesn't respect the following condition : count < 0");
            

}


}


}