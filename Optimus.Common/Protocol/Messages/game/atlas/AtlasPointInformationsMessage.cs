


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AtlasPointInformationsMessage : NetworkMessage
{

public const uint Id = 5956;
public override uint MessageId
{
    get { return Id; }
}

public Types.AtlasPointsInformations type;
        

public AtlasPointInformationsMessage()
{
}

public AtlasPointInformationsMessage(Types.AtlasPointsInformations type)
        {
            this.type = type;
        }
        

public override void Serialize(BigEndianWriter writer)
{

type.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

type = new Types.AtlasPointsInformations();
            type.Deserialize(reader);
            

}


}


}