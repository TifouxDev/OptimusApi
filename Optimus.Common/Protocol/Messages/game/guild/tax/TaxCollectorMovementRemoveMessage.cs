


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TaxCollectorMovementRemoveMessage : NetworkMessage
{

public const uint Id = 5915;
public override uint MessageId
{
    get { return Id; }
}

public int collectorId;
        

public TaxCollectorMovementRemoveMessage()
{
}

public TaxCollectorMovementRemoveMessage(int collectorId)
        {
            this.collectorId = collectorId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(collectorId);
            

}

public override void Deserialize(BigEndianReader reader)
{

collectorId = reader.ReadInt();
            

}


}


}