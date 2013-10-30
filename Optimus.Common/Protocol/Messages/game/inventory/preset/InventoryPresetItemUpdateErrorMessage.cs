


















// Generated on 10/27/2013 07:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class InventoryPresetItemUpdateErrorMessage : NetworkMessage
{

public const uint Id = 6211;
public override uint MessageId
{
    get { return Id; }
}

public sbyte code;
        

public InventoryPresetItemUpdateErrorMessage()
{
}

public InventoryPresetItemUpdateErrorMessage(sbyte code)
        {
            this.code = code;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(code);
            

}

public override void Deserialize(BigEndianReader reader)
{

code = reader.ReadSByte();
            if (code < 0)
                throw new Exception("Forbidden value on code = " + code + ", it doesn't respect the following condition : code < 0");
            

}


}


}