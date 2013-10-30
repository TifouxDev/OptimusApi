


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangePlayerRequestMessage : ExchangeRequestMessage
{

public const uint Id = 5773;
public override uint MessageId
{
    get { return Id; }
}

public int target;
        

public ExchangePlayerRequestMessage()
{
}

public ExchangePlayerRequestMessage(sbyte exchangeType, int target)
         : base(exchangeType)
        {
            this.target = target;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(target);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            target = reader.ReadInt();
            if (target < 0)
                throw new Exception("Forbidden value on target = " + target + ", it doesn't respect the following condition : target < 0");
            

}


}


}