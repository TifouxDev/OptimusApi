


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildGetInformationsMessage : NetworkMessage
{

public const uint Id = 5550;
public override uint MessageId
{
    get { return Id; }
}

public sbyte infoType;
        

public GuildGetInformationsMessage()
{
}

public GuildGetInformationsMessage(sbyte infoType)
        {
            this.infoType = infoType;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(infoType);
            

}

public override void Deserialize(BigEndianReader reader)
{

infoType = reader.ReadSByte();
            if (infoType < 0)
                throw new Exception("Forbidden value on infoType = " + infoType + ", it doesn't respect the following condition : infoType < 0");
            

}


}


}