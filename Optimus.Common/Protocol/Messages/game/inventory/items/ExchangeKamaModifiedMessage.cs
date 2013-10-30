


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeKamaModifiedMessage : ExchangeObjectMessage
{

public const uint Id = 5521;
public override uint MessageId
{
    get { return Id; }
}

public int quantity;
        

public ExchangeKamaModifiedMessage()
{
}

public ExchangeKamaModifiedMessage(bool remote, int quantity)
         : base(remote)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(quantity);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            quantity = reader.ReadInt();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}