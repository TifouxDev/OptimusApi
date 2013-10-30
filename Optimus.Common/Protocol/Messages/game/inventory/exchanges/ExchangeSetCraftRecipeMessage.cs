


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeSetCraftRecipeMessage : NetworkMessage
{

public const uint Id = 6389;
public override uint MessageId
{
    get { return Id; }
}

public short objectGID;
        

public ExchangeSetCraftRecipeMessage()
{
}

public ExchangeSetCraftRecipeMessage(short objectGID)
        {
            this.objectGID = objectGID;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(objectGID);
            

}

public override void Deserialize(BigEndianReader reader)
{

objectGID = reader.ReadShort();
            if (objectGID < 0)
                throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            

}


}


}