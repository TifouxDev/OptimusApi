


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeStartOkNpcTradeMessage : NetworkMessage
{

public const uint Id = 5785;
public override uint MessageId
{
    get { return Id; }
}

public int npcId;
        

public ExchangeStartOkNpcTradeMessage()
{
}

public ExchangeStartOkNpcTradeMessage(int npcId)
        {
            this.npcId = npcId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(npcId);
            

}

public override void Deserialize(BigEndianReader reader)
{

npcId = reader.ReadInt();
            

}


}


}