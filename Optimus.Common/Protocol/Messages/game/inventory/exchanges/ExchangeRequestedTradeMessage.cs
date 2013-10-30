


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeRequestedTradeMessage : ExchangeRequestedMessage
{

public const uint Id = 5523;
public override uint MessageId
{
    get { return Id; }
}

public int source;
        public int target;
        

public ExchangeRequestedTradeMessage()
{
}

public ExchangeRequestedTradeMessage(sbyte exchangeType, int source, int target)
         : base(exchangeType)
        {
            this.source = source;
            this.target = target;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(source);
            writer.WriteInt(target);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            source = reader.ReadInt();
            if (source < 0)
                throw new Exception("Forbidden value on source = " + source + ", it doesn't respect the following condition : source < 0");
            target = reader.ReadInt();
            if (target < 0)
                throw new Exception("Forbidden value on target = " + target + ", it doesn't respect the following condition : target < 0");
            

}


}


}