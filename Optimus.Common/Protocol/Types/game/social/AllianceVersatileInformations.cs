


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class AllianceVersatileInformations
{

public const short Id = 432;
public virtual short TypeId
{
    get { return Id; }
}

public int allianceId;
        public short nbGuilds;
        public short nbMembers;
        public short nbSubarea;
        

public AllianceVersatileInformations()
{
}

public AllianceVersatileInformations(int allianceId, short nbGuilds, short nbMembers, short nbSubarea)
        {
            this.allianceId = allianceId;
            this.nbGuilds = nbGuilds;
            this.nbMembers = nbMembers;
            this.nbSubarea = nbSubarea;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteInt(allianceId);
            writer.WriteShort(nbGuilds);
            writer.WriteShort(nbMembers);
            writer.WriteShort(nbSubarea);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

allianceId = reader.ReadInt();
            if (allianceId < 0)
                throw new Exception("Forbidden value on allianceId = " + allianceId + ", it doesn't respect the following condition : allianceId < 0");
            nbGuilds = reader.ReadShort();
            if (nbGuilds < 0)
                throw new Exception("Forbidden value on nbGuilds = " + nbGuilds + ", it doesn't respect the following condition : nbGuilds < 0");
            nbMembers = reader.ReadShort();
            if (nbMembers < 0)
                throw new Exception("Forbidden value on nbMembers = " + nbMembers + ", it doesn't respect the following condition : nbMembers < 0");
            nbSubarea = reader.ReadShort();
            if (nbSubarea < 0)
                throw new Exception("Forbidden value on nbSubarea = " + nbSubarea + ", it doesn't respect the following condition : nbSubarea < 0");
            

}


}


}