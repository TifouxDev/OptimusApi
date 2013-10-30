


















// Generated on 10/27/2013 07:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class StatsUpgradeResultMessage : NetworkMessage
{

public const uint Id = 5609;
public override uint MessageId
{
    get { return Id; }
}

public short nbCharacBoost;
        

public StatsUpgradeResultMessage()
{
}

public StatsUpgradeResultMessage(short nbCharacBoost)
        {
            this.nbCharacBoost = nbCharacBoost;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(nbCharacBoost);
            

}

public override void Deserialize(BigEndianReader reader)
{

nbCharacBoost = reader.ReadShort();
            if (nbCharacBoost < 0)
                throw new Exception("Forbidden value on nbCharacBoost = " + nbCharacBoost + ", it doesn't respect the following condition : nbCharacBoost < 0");
            

}


}


}