


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class BasicGuildInformations : AbstractSocialGroupInfos
{

public const short Id = 365;
public override short TypeId
{
    get { return Id; }
}

public int guildId;
        public string guildName;
        

public BasicGuildInformations()
{
}

public BasicGuildInformations(int guildId, string guildName)
        {
            this.guildId = guildId;
            this.guildName = guildName;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(guildId);
            writer.WriteUTF(guildName);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            guildId = reader.ReadInt();
            if (guildId < 0)
                throw new Exception("Forbidden value on guildId = " + guildId + ", it doesn't respect the following condition : guildId < 0");
            guildName = reader.ReadUTF();
            

}


}


}