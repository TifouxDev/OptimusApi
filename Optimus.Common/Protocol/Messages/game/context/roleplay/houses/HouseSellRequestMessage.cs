


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class HouseSellRequestMessage : NetworkMessage
{

public const uint Id = 5697;
public override uint MessageId
{
    get { return Id; }
}

public int amount;
        

public HouseSellRequestMessage()
{
}

public HouseSellRequestMessage(int amount)
        {
            this.amount = amount;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(amount);
            

}

public override void Deserialize(BigEndianReader reader)
{

amount = reader.ReadInt();
            if (amount < 0)
                throw new Exception("Forbidden value on amount = " + amount + ", it doesn't respect the following condition : amount < 0");
            

}


}


}