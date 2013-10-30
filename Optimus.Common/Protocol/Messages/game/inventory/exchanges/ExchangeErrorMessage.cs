


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeErrorMessage : NetworkMessage
{

public const uint Id = 5513;
public override uint MessageId
{
    get { return Id; }
}

public sbyte errorType;
        

public ExchangeErrorMessage()
{
}

public ExchangeErrorMessage(sbyte errorType)
        {
            this.errorType = errorType;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(errorType);
            

}

public override void Deserialize(BigEndianReader reader)
{

errorType = reader.ReadSByte();
            

}


}


}