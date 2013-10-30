


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ShortcutBarRemoveErrorMessage : NetworkMessage
{

public const uint Id = 6222;
public override uint MessageId
{
    get { return Id; }
}

public sbyte error;
        

public ShortcutBarRemoveErrorMessage()
{
}

public ShortcutBarRemoveErrorMessage(sbyte error)
        {
            this.error = error;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(error);
            

}

public override void Deserialize(BigEndianReader reader)
{

error = reader.ReadSByte();
            if (error < 0)
                throw new Exception("Forbidden value on error = " + error + ", it doesn't respect the following condition : error < 0");
            

}


}


}