


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ShortcutBarRefreshMessage : NetworkMessage
{

public const uint Id = 6229;
public override uint MessageId
{
    get { return Id; }
}

public sbyte barType;
        public Types.Shortcut shortcut;
        

public ShortcutBarRefreshMessage()
{
}

public ShortcutBarRefreshMessage(sbyte barType, Types.Shortcut shortcut)
        {
            this.barType = barType;
            this.shortcut = shortcut;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(barType);
            writer.WriteShort(shortcut.TypeId);
            shortcut.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

barType = reader.ReadSByte();
            if (barType < 0)
                throw new Exception("Forbidden value on barType = " + barType + ", it doesn't respect the following condition : barType < 0");
            shortcut = Types.ProtocolTypeManager.GetInstance<Types.Shortcut>(reader.ReadShort());
            shortcut.Deserialize(reader);
            

}


}


}