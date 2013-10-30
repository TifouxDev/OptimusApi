


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeRemovedPaymentForCraftMessage : NetworkMessage
{

public const uint Id = 6031;
public override uint MessageId
{
    get { return Id; }
}

public bool onlySuccess;
        public int objectUID;
        

public ExchangeRemovedPaymentForCraftMessage()
{
}

public ExchangeRemovedPaymentForCraftMessage(bool onlySuccess, int objectUID)
        {
            this.onlySuccess = onlySuccess;
            this.objectUID = objectUID;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(onlySuccess);
            writer.WriteInt(objectUID);
            

}

public override void Deserialize(BigEndianReader reader)
{

onlySuccess = reader.ReadBoolean();
            objectUID = reader.ReadInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            

}


}


}