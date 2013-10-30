


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class GuildInAllianceVersatileInformations : GuildVersatileInformations
{

public const short Id = 437;
public override short TypeId
{
    get { return Id; }
}

public int allianceId;
        

public GuildInAllianceVersatileInformations()
{
}

public GuildInAllianceVersatileInformations(int guildId, int leaderId, ushort guildLevel, ushort nbMembers, int allianceId)
         : base(guildId, leaderId, guildLevel, nbMembers)
        {
            this.allianceId = allianceId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(allianceId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            allianceId = reader.ReadInt();
            if (allianceId < 0)
                throw new Exception("Forbidden value on allianceId = " + allianceId + ", it doesn't respect the following condition : allianceId < 0");
            

}


}


}