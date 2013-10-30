


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeObjectMoveKamaMessage : NetworkMessage
{

public const uint Id = 5520;
public override uint MessageId
{
    get { return Id; }
}

public int quantity;
        

public ExchangeObjectMoveKamaMessage()
{
}

public ExchangeObjectMoveKamaMessage(int quantity)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(quantity);
            

}

public override void Deserialize(BigEndianReader reader)
{

quantity = reader.ReadInt();
            

}


}


}