


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class BasicAllianceInformations : AbstractSocialGroupInfos
{

public const short Id = 419;
public override short TypeId
{
    get { return Id; }
}

public int allianceId;
        public string allianceTag;
        

public BasicAllianceInformations()
{
}

public BasicAllianceInformations(int allianceId, string allianceTag)
        {
            this.allianceId = allianceId;
            this.allianceTag = allianceTag;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(allianceId);
            writer.WriteUTF(allianceTag);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            allianceId = reader.ReadInt();
            if (allianceId < 0)
                throw new Exception("Forbidden value on allianceId = " + allianceId + ", it doesn't respect the following condition : allianceId < 0");
            allianceTag = reader.ReadUTF();
            

}


}


}