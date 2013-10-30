// Generated on 07/12/2013 12:13:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildUIOpenedMessage : NetworkMessage
{

public const uint Id = 5561;
public override uint MessageId
{
    get { return Id; }
}

public sbyte type;
        

public GuildUIOpenedMessage()
{
}

public GuildUIOpenedMessage(sbyte type)
        {
            this.type = type;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(type);
            

}

public override void Deserialize(BigEndianReader reader)
{

type = reader.ReadSByte();
            if (type<0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type<0");
            

}


}


}