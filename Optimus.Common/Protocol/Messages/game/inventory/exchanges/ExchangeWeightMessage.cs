


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeWeightMessage : NetworkMessage
{

public const uint Id = 5793;
public override uint MessageId
{
    get { return Id; }
}

public int currentWeight;
        public int maxWeight;
        

public ExchangeWeightMessage()
{
}

public ExchangeWeightMessage(int currentWeight, int maxWeight)
        {
            this.currentWeight = currentWeight;
            this.maxWeight = maxWeight;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(currentWeight);
            writer.WriteInt(maxWeight);
            

}

public override void Deserialize(BigEndianReader reader)
{

currentWeight = reader.ReadInt();
            if (currentWeight < 0)
                throw new Exception("Forbidden value on currentWeight = " + currentWeight + ", it doesn't respect the following condition : currentWeight < 0");
            maxWeight = reader.ReadInt();
            if (maxWeight < 0)
                throw new Exception("Forbidden value on maxWeight = " + maxWeight + ", it doesn't respect the following condition : maxWeight < 0");
            

}


}


}