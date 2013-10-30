


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeStartedWithStorageMessage : ExchangeStartedMessage
{

public const uint Id = 6236;
public override uint MessageId
{
    get { return Id; }
}

public int storageMaxSlot;
        

public ExchangeStartedWithStorageMessage()
{
}

public ExchangeStartedWithStorageMessage(sbyte exchangeType, int storageMaxSlot)
         : base(exchangeType)
        {
            this.storageMaxSlot = storageMaxSlot;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(storageMaxSlot);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            storageMaxSlot = reader.ReadInt();
            if (storageMaxSlot < 0)
                throw new Exception("Forbidden value on storageMaxSlot = " + storageMaxSlot + ", it doesn't respect the following condition : storageMaxSlot < 0");
            

}


}


}