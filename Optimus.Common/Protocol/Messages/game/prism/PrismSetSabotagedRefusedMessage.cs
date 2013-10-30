


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PrismSetSabotagedRefusedMessage : NetworkMessage
{

public const uint Id = 6466;
public override uint MessageId
{
    get { return Id; }
}

public short subAreaId;
        public sbyte reason;
        

public PrismSetSabotagedRefusedMessage()
{
}

public PrismSetSabotagedRefusedMessage(short subAreaId, sbyte reason)
        {
            this.subAreaId = subAreaId;
            this.reason = reason;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(subAreaId);
            writer.WriteSByte(reason);
            

}

public override void Deserialize(BigEndianReader reader)
{

subAreaId = reader.ReadShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            reason = reader.ReadSByte();
            

}


}


}