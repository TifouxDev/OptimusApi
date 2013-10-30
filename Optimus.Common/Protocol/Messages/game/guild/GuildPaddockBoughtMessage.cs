


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildPaddockBoughtMessage : NetworkMessage
{

public const uint Id = 5952;
public override uint MessageId
{
    get { return Id; }
}

public Types.PaddockContentInformations paddockInfo;
        

public GuildPaddockBoughtMessage()
{
}

public GuildPaddockBoughtMessage(Types.PaddockContentInformations paddockInfo)
        {
            this.paddockInfo = paddockInfo;
        }
        

public override void Serialize(BigEndianWriter writer)
{

paddockInfo.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

paddockInfo = new Types.PaddockContentInformations();
            paddockInfo.Deserialize(reader);
            

}


}


}