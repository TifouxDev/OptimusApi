


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage : NetworkMessage
{

public const uint Id = 6021;
public override uint MessageId
{
    get { return Id; }
}

public bool allow;
        

public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage()
{
}

public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage(bool allow)
        {
            this.allow = allow;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(allow);
            

}

public override void Deserialize(BigEndianReader reader)
{

allow = reader.ReadBoolean();
            

}


}


}