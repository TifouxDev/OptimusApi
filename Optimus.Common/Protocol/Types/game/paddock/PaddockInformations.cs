


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class PaddockInformations
{

public const short Id = 132;
public virtual short TypeId
{
    get { return Id; }
}

public short maxOutdoorMount;
        public short maxItems;
        

public PaddockInformations()
{
}

public PaddockInformations(short maxOutdoorMount, short maxItems)
        {
            this.maxOutdoorMount = maxOutdoorMount;
            this.maxItems = maxItems;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteShort(maxOutdoorMount);
            writer.WriteShort(maxItems);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

maxOutdoorMount = reader.ReadShort();
            if (maxOutdoorMount < 0)
                throw new Exception("Forbidden value on maxOutdoorMount = " + maxOutdoorMount + ", it doesn't respect the following condition : maxOutdoorMount < 0");
            maxItems = reader.ReadShort();
            if (maxItems < 0)
                throw new Exception("Forbidden value on maxItems = " + maxItems + ", it doesn't respect the following condition : maxItems < 0");
            

}


}


}