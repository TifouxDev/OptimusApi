


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeObjectMoveMessage : NetworkMessage
{

public const uint Id = 5518;
public override uint MessageId
{
    get { return Id; }
}

public int objectUID;
        public int quantity;
        

public ExchangeObjectMoveMessage()
{
}

public ExchangeObjectMoveMessage(int objectUID, int quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(objectUID);
            writer.WriteInt(quantity);
            

}

public override void Deserialize(BigEndianReader reader)
{

objectUID = reader.ReadInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            quantity = reader.ReadInt();
            

}


}


}