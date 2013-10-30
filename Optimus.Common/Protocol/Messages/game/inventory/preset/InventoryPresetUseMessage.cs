


















// Generated on 10/27/2013 07:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class InventoryPresetUseMessage : NetworkMessage
{

public const uint Id = 6167;
public override uint MessageId
{
    get { return Id; }
}

public sbyte presetId;
        

public InventoryPresetUseMessage()
{
}

public InventoryPresetUseMessage(sbyte presetId)
        {
            this.presetId = presetId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(presetId);
            

}

public override void Deserialize(BigEndianReader reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            

}


}


}