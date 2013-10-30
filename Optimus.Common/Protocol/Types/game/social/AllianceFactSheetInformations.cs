


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class AllianceFactSheetInformations : AllianceInformations
{

public const short Id = 421;
public override short TypeId
{
    get { return Id; }
}

public int creationDate;
        

public AllianceFactSheetInformations()
{
}

public AllianceFactSheetInformations(int allianceId, string allianceTag, string allianceName, Types.GuildEmblem allianceEmblem, int creationDate)
         : base(allianceId, allianceTag, allianceName, allianceEmblem)
        {
            this.creationDate = creationDate;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(creationDate);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            creationDate = reader.ReadInt();
            if (creationDate < 0)
                throw new Exception("Forbidden value on creationDate = " + creationDate + ", it doesn't respect the following condition : creationDate < 0");
            

}


}


}