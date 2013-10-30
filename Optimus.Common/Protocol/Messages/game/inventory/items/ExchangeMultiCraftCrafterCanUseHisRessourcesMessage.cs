


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeMultiCraftCrafterCanUseHisRessourcesMessage : NetworkMessage
{

public const uint Id = 6020;
public override uint MessageId
{
    get { return Id; }
}

public bool allowed;
        

public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage()
{
}

public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage(bool allowed)
        {
            this.allowed = allowed;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(allowed);
            

}

public override void Deserialize(BigEndianReader reader)
{

allowed = reader.ReadBoolean();
            

}


}


}