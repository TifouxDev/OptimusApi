


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeCraftResultMessage : NetworkMessage
{

public const uint Id = 5790;
public override uint MessageId
{
    get { return Id; }
}

public sbyte craftResult;
        

public ExchangeCraftResultMessage()
{
}

public ExchangeCraftResultMessage(sbyte craftResult)
        {
            this.craftResult = craftResult;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(craftResult);
            

}

public override void Deserialize(BigEndianReader reader)
{

craftResult = reader.ReadSByte();
            if (craftResult < 0)
                throw new Exception("Forbidden value on craftResult = " + craftResult + ", it doesn't respect the following condition : craftResult < 0");
            

}


}


}