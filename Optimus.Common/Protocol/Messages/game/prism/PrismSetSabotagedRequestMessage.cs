


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PrismSetSabotagedRequestMessage : NetworkMessage
{

public const uint Id = 6468;
public override uint MessageId
{
    get { return Id; }
}

public short subAreaId;
        

public PrismSetSabotagedRequestMessage()
{
}

public PrismSetSabotagedRequestMessage(short subAreaId)
        {
            this.subAreaId = subAreaId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(subAreaId);
            

}

public override void Deserialize(BigEndianReader reader)
{

subAreaId = reader.ReadShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            

}


}


}