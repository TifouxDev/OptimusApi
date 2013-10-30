


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeCraftResultWithObjectIdMessage : ExchangeCraftResultMessage
{

public const uint Id = 6000;
public override uint MessageId
{
    get { return Id; }
}

public int objectGenericId;
        

public ExchangeCraftResultWithObjectIdMessage()
{
}

public ExchangeCraftResultWithObjectIdMessage(sbyte craftResult, int objectGenericId)
         : base(craftResult)
        {
            this.objectGenericId = objectGenericId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(objectGenericId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            objectGenericId = reader.ReadInt();
            if (objectGenericId < 0)
                throw new Exception("Forbidden value on objectGenericId = " + objectGenericId + ", it doesn't respect the following condition : objectGenericId < 0");
            

}


}


}