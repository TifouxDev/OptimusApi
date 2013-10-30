


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TaxCollectorErrorMessage : NetworkMessage
{

public const uint Id = 5634;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public TaxCollectorErrorMessage()
{
}

public TaxCollectorErrorMessage(sbyte reason)
        {
            this.reason = reason;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(reason);
            

}

public override void Deserialize(BigEndianReader reader)
{

reason = reader.ReadSByte();
            

}


}


}