


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ShortcutBarRemoveRequestMessage : NetworkMessage
{

public const uint Id = 6228;
public override uint MessageId
{
    get { return Id; }
}

public sbyte barType;
        public int slot;
        

public ShortcutBarRemoveRequestMessage()
{
}

public ShortcutBarRemoveRequestMessage(sbyte barType, int slot)
        {
            this.barType = barType;
            this.slot = slot;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(barType);
            writer.WriteInt(slot);
            

}

public override void Deserialize(BigEndianReader reader)
{

barType = reader.ReadSByte();
            if (barType < 0)
                throw new Exception("Forbidden value on barType = " + barType + ", it doesn't respect the following condition : barType < 0");
            slot = reader.ReadInt();
            if (slot < 0 || slot > 99)
                throw new Exception("Forbidden value on slot = " + slot + ", it doesn't respect the following condition : slot < 0 || slot > 99");
            

}


}


}