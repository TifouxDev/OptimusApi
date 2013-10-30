


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildPaddockRemovedMessage : NetworkMessage
{

public const uint Id = 5955;
public override uint MessageId
{
    get { return Id; }
}

public int paddockId;
        

public GuildPaddockRemovedMessage()
{
}

public GuildPaddockRemovedMessage(int paddockId)
        {
            this.paddockId = paddockId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(paddockId);
            

}

public override void Deserialize(BigEndianReader reader)
{

paddockId = reader.ReadInt();
            

}


}


}