


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class TaxCollectorGuildInformations : TaxCollectorComplementaryInformations
{

public const short Id = 446;
public override short TypeId
{
    get { return Id; }
}

public Types.BasicGuildInformations guild;
        

public TaxCollectorGuildInformations()
{
}

public TaxCollectorGuildInformations(Types.BasicGuildInformations guild)
        {
            this.guild = guild;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            guild.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
            

}


}


}