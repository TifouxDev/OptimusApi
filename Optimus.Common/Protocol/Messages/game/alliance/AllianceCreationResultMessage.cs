


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceCreationResultMessage : NetworkMessage
{

public const uint Id = 6391;
public override uint MessageId
{
    get { return Id; }
}

public sbyte result;
        

public AllianceCreationResultMessage()
{
}

public AllianceCreationResultMessage(sbyte result)
        {
            this.result = result;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(result);
            

}

public override void Deserialize(BigEndianReader reader)
{

result = reader.ReadSByte();
            if (result < 0)
                throw new Exception("Forbidden value on result = " + result + ", it doesn't respect the following condition : result < 0");
            

}


}


}