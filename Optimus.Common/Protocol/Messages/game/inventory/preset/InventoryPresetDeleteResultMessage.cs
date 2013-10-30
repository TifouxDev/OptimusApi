


















// Generated on 10/27/2013 07:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class InventoryPresetDeleteResultMessage : NetworkMessage
{

public const uint Id = 6173;
public override uint MessageId
{
    get { return Id; }
}

public sbyte presetId;
        public sbyte code;
        

public InventoryPresetDeleteResultMessage()
{
}

public InventoryPresetDeleteResultMessage(sbyte presetId, sbyte code)
        {
            this.presetId = presetId;
            this.code = code;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(presetId);
            writer.WriteSByte(code);
            

}

public override void Deserialize(BigEndianReader reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            code = reader.ReadSByte();
            if (code < 0)
                throw new Exception("Forbidden value on code = " + code + ", it doesn't respect the following condition : code < 0");
            

}


}


}