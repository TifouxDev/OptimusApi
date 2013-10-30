


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeRequestOnTaxCollectorMessage : NetworkMessage
{

public const uint Id = 5779;
public override uint MessageId
{
    get { return Id; }
}

public int taxCollectorId;
        

public ExchangeRequestOnTaxCollectorMessage()
{
}

public ExchangeRequestOnTaxCollectorMessage(int taxCollectorId)
        {
            this.taxCollectorId = taxCollectorId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(taxCollectorId);
            

}

public override void Deserialize(BigEndianReader reader)
{

taxCollectorId = reader.ReadInt();
            

}


}


}