


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class KamasUpdateMessage : NetworkMessage
{

public const uint Id = 5537;
public override uint MessageId
{
    get { return Id; }
}

public int kamasTotal;
        

public KamasUpdateMessage()
{
}

public KamasUpdateMessage(int kamasTotal)
        {
            this.kamasTotal = kamasTotal;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(kamasTotal);
            

}

public override void Deserialize(BigEndianReader reader)
{

kamasTotal = reader.ReadInt();
            

}


}


}