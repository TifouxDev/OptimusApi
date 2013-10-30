


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class InventoryWeightMessage : NetworkMessage
{

public const uint Id = 3009;
public override uint MessageId
{
    get { return Id; }
}

public int weight;
        public int weightMax;
        

public InventoryWeightMessage()
{
}

public InventoryWeightMessage(int weight, int weightMax)
        {
            this.weight = weight;
            this.weightMax = weightMax;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(weight);
            writer.WriteInt(weightMax);
            

}

public override void Deserialize(BigEndianReader reader)
{

weight = reader.ReadInt();
            if (weight < 0)
                throw new Exception("Forbidden value on weight = " + weight + ", it doesn't respect the following condition : weight < 0");
            weightMax = reader.ReadInt();
            if (weightMax < 0)
                throw new Exception("Forbidden value on weightMax = " + weightMax + ", it doesn't respect the following condition : weightMax < 0");
            

}


}


}