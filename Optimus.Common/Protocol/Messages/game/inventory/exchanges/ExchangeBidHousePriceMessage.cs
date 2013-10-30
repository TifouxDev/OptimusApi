


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeBidHousePriceMessage : NetworkMessage
{

public const uint Id = 5805;
public override uint MessageId
{
    get { return Id; }
}

public int genId;
        

public ExchangeBidHousePriceMessage()
{
}

public ExchangeBidHousePriceMessage(int genId)
        {
            this.genId = genId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(genId);
            

}

public override void Deserialize(BigEndianReader reader)
{

genId = reader.ReadInt();
            if (genId < 0)
                throw new Exception("Forbidden value on genId = " + genId + ", it doesn't respect the following condition : genId < 0");
            

}


}


}