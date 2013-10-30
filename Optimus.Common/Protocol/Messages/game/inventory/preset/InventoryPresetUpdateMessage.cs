


















// Generated on 10/27/2013 07:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class InventoryPresetUpdateMessage : NetworkMessage
{

public const uint Id = 6171;
public override uint MessageId
{
    get { return Id; }
}

public Types.Preset preset;
        

public InventoryPresetUpdateMessage()
{
}

public InventoryPresetUpdateMessage(Types.Preset preset)
        {
            this.preset = preset;
        }
        

public override void Serialize(BigEndianWriter writer)
{

preset.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

preset = new Types.Preset();
            preset.Deserialize(reader);
            

}


}


}