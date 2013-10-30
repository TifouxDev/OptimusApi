


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeGoldPaymentForCraftMessage : NetworkMessage
{

public const uint Id = 5833;
public override uint MessageId
{
    get { return Id; }
}

public bool onlySuccess;
        public int goldSum;
        

public ExchangeGoldPaymentForCraftMessage()
{
}

public ExchangeGoldPaymentForCraftMessage(bool onlySuccess, int goldSum)
        {
            this.onlySuccess = onlySuccess;
            this.goldSum = goldSum;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(onlySuccess);
            writer.WriteInt(goldSum);
            

}

public override void Deserialize(BigEndianReader reader)
{

onlySuccess = reader.ReadBoolean();
            goldSum = reader.ReadInt();
            if (goldSum < 0)
                throw new Exception("Forbidden value on goldSum = " + goldSum + ", it doesn't respect the following condition : goldSum < 0");
            

}


}


}