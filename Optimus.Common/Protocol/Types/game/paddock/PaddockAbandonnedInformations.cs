


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class PaddockAbandonnedInformations : PaddockBuyableInformations
{

public const short Id = 133;
public override short TypeId
{
    get { return Id; }
}

public int guildId;
        

public PaddockAbandonnedInformations()
{
}

public PaddockAbandonnedInformations(short maxOutdoorMount, short maxItems, int price, bool locked, int guildId)
         : base(maxOutdoorMount, maxItems, price, locked)
        {
            this.guildId = guildId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(guildId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            guildId = reader.ReadInt();
            

}


}


}