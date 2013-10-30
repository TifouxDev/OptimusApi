


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeCraftSlotCountIncreasedMessage : NetworkMessage
{

public const uint Id = 6125;
public override uint MessageId
{
    get { return Id; }
}

public sbyte newMaxSlot;
        

public ExchangeCraftSlotCountIncreasedMessage()
{
}

public ExchangeCraftSlotCountIncreasedMessage(sbyte newMaxSlot)
        {
            this.newMaxSlot = newMaxSlot;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(newMaxSlot);
            

}

public override void Deserialize(BigEndianReader reader)
{

newMaxSlot = reader.ReadSByte();
            if (newMaxSlot < 0)
                throw new Exception("Forbidden value on newMaxSlot = " + newMaxSlot + ", it doesn't respect the following condition : newMaxSlot < 0");
            

}


}


}