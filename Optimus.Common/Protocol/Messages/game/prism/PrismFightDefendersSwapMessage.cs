


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PrismFightDefendersSwapMessage : NetworkMessage
{

public const uint Id = 5902;
public override uint MessageId
{
    get { return Id; }
}

public short subAreaId;
        public double fightId;
        public int fighterId1;
        public int fighterId2;
        

public PrismFightDefendersSwapMessage()
{
}

public PrismFightDefendersSwapMessage(short subAreaId, double fightId, int fighterId1, int fighterId2)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.fighterId1 = fighterId1;
            this.fighterId2 = fighterId2;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(subAreaId);
            writer.WriteDouble(fightId);
            writer.WriteInt(fighterId1);
            writer.WriteInt(fighterId2);
            

}

public override void Deserialize(BigEndianReader reader)
{

subAreaId = reader.ReadShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            fightId = reader.ReadDouble();
            fighterId1 = reader.ReadInt();
            if (fighterId1 < 0)
                throw new Exception("Forbidden value on fighterId1 = " + fighterId1 + ", it doesn't respect the following condition : fighterId1 < 0");
            fighterId2 = reader.ReadInt();
            if (fighterId2 < 0)
                throw new Exception("Forbidden value on fighterId2 = " + fighterId2 + ", it doesn't respect the following condition : fighterId2 < 0");
            

}


}


}