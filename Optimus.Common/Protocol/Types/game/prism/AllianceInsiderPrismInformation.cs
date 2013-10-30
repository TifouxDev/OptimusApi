


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class AllianceInsiderPrismInformation : PrismInformation
{

public const short Id = 431;
public override short TypeId
{
    get { return Id; }
}

public int lastTimeSlotModificationDate;
        public int lastTimeSlotModificationAuthorGuildId;
        public int lastTimeSlotModificationAuthorId;
        public string lastTimeSlotModificationAuthorName;
        public bool hasTeleporterModule;
        

public AllianceInsiderPrismInformation()
{
}

public AllianceInsiderPrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, int rewardTokenCount, int lastTimeSlotModificationDate, int lastTimeSlotModificationAuthorGuildId, int lastTimeSlotModificationAuthorId, string lastTimeSlotModificationAuthorName, bool hasTeleporterModule)
         : base(typeId, state, nextVulnerabilityDate, placementDate, rewardTokenCount)
        {
            this.lastTimeSlotModificationDate = lastTimeSlotModificationDate;
            this.lastTimeSlotModificationAuthorGuildId = lastTimeSlotModificationAuthorGuildId;
            this.lastTimeSlotModificationAuthorId = lastTimeSlotModificationAuthorId;
            this.lastTimeSlotModificationAuthorName = lastTimeSlotModificationAuthorName;
            this.hasTeleporterModule = hasTeleporterModule;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(lastTimeSlotModificationDate);
            writer.WriteInt(lastTimeSlotModificationAuthorGuildId);
            writer.WriteInt(lastTimeSlotModificationAuthorId);
            writer.WriteUTF(lastTimeSlotModificationAuthorName);
            writer.WriteBoolean(hasTeleporterModule);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            lastTimeSlotModificationDate = reader.ReadInt();
            if (lastTimeSlotModificationDate < 0)
                throw new Exception("Forbidden value on lastTimeSlotModificationDate = " + lastTimeSlotModificationDate + ", it doesn't respect the following condition : lastTimeSlotModificationDate < 0");
            lastTimeSlotModificationAuthorGuildId = reader.ReadInt();
            if (lastTimeSlotModificationAuthorGuildId < 0)
                throw new Exception("Forbidden value on lastTimeSlotModificationAuthorGuildId = " + lastTimeSlotModificationAuthorGuildId + ", it doesn't respect the following condition : lastTimeSlotModificationAuthorGuildId < 0");
            lastTimeSlotModificationAuthorId = reader.ReadInt();
            if (lastTimeSlotModificationAuthorId < 0)
                throw new Exception("Forbidden value on lastTimeSlotModificationAuthorId = " + lastTimeSlotModificationAuthorId + ", it doesn't respect the following condition : lastTimeSlotModificationAuthorId < 0");
            lastTimeSlotModificationAuthorName = reader.ReadUTF();
            hasTeleporterModule = reader.ReadBoolean();
            

}


}


}