


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeModifiedPaymentForCraftMessage : NetworkMessage
{

public const uint Id = 5832;
public override uint MessageId
{
    get { return Id; }
}

public bool onlySuccess;
        public Types.ObjectItemNotInContainer @object;
        

public ExchangeModifiedPaymentForCraftMessage()
{
}

public ExchangeModifiedPaymentForCraftMessage(bool onlySuccess, Types.ObjectItemNotInContainer @object)
        {
            this.onlySuccess = onlySuccess;
            this.@object = @object;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(onlySuccess);
            @object.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

onlySuccess = reader.ReadBoolean();
            @object = new Types.ObjectItemNotInContainer();
            @object.Deserialize(reader);
            

}


}


}