


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildLevelUpMessage : NetworkMessage
{

public const uint Id = 6062;
public override uint MessageId
{
    get { return Id; }
}

public byte newLevel;
        

public GuildLevelUpMessage()
{
}

public GuildLevelUpMessage(byte newLevel)
        {
            this.newLevel = newLevel;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteByte(newLevel);
            

}

public override void Deserialize(BigEndianReader reader)
{

newLevel = reader.ReadByte();
            if (newLevel < 2 || newLevel > 200)
                throw new Exception("Forbidden value on newLevel = " + newLevel + ", it doesn't respect the following condition : newLevel < 2 || newLevel > 200");
            

}


}


}