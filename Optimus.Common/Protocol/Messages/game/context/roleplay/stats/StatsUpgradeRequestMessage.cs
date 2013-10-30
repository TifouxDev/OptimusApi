


















// Generated on 10/27/2013 07:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class StatsUpgradeRequestMessage : NetworkMessage
{

public const uint Id = 5610;
public override uint MessageId
{
    get { return Id; }
}

public sbyte statId;
        public short boostPoint;
        

public StatsUpgradeRequestMessage()
{
}

public StatsUpgradeRequestMessage(sbyte statId, short boostPoint)
        {
            this.statId = statId;
            this.boostPoint = boostPoint;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(statId);
            writer.WriteShort(boostPoint);
            

}

public override void Deserialize(BigEndianReader reader)
{

statId = reader.ReadSByte();
            if (statId < 0)
                throw new Exception("Forbidden value on statId = " + statId + ", it doesn't respect the following condition : statId < 0");
            boostPoint = reader.ReadShort();
            if (boostPoint < 0)
                throw new Exception("Forbidden value on boostPoint = " + boostPoint + ", it doesn't respect the following condition : boostPoint < 0");
            

}


}


}