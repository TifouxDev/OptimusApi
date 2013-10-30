


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeBidHouseGenericItemAddedMessage : NetworkMessage
{

public const uint Id = 5947;
public override uint MessageId
{
    get { return Id; }
}

public int objGenericId;
        

public ExchangeBidHouseGenericItemAddedMessage()
{
}

public ExchangeBidHouseGenericItemAddedMessage(int objGenericId)
        {
            this.objGenericId = objGenericId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(objGenericId);
            

}

public override void Deserialize(BigEndianReader reader)
{

objGenericId = reader.ReadInt();
            

}


}


}