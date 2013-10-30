


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameRolePlayTaxCollectorFightRequestMessage : NetworkMessage
{

public const uint Id = 5954;
public override uint MessageId
{
    get { return Id; }
}

public int taxCollectorId;
        

public GameRolePlayTaxCollectorFightRequestMessage()
{
}

public GameRolePlayTaxCollectorFightRequestMessage(int taxCollectorId)
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