


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharacterCapabilitiesMessage : NetworkMessage
{

public const uint Id = 6339;
public override uint MessageId
{
    get { return Id; }
}

public int guildEmblemSymbolCategories;
        

public CharacterCapabilitiesMessage()
{
}

public CharacterCapabilitiesMessage(int guildEmblemSymbolCategories)
        {
            this.guildEmblemSymbolCategories = guildEmblemSymbolCategories;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(guildEmblemSymbolCategories);
            

}

public override void Deserialize(BigEndianReader reader)
{

guildEmblemSymbolCategories = reader.ReadInt();
            if (guildEmblemSymbolCategories < 0)
                throw new Exception("Forbidden value on guildEmblemSymbolCategories = " + guildEmblemSymbolCategories + ", it doesn't respect the following condition : guildEmblemSymbolCategories < 0");
            

}


}


}