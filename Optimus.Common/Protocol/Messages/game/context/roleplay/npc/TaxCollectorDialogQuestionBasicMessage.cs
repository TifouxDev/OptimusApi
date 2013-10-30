


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TaxCollectorDialogQuestionBasicMessage : NetworkMessage
{

public const uint Id = 5619;
public override uint MessageId
{
    get { return Id; }
}

public Types.BasicGuildInformations guildInfo;
        

public TaxCollectorDialogQuestionBasicMessage()
{
}

public TaxCollectorDialogQuestionBasicMessage(Types.BasicGuildInformations guildInfo)
        {
            this.guildInfo = guildInfo;
        }
        

public override void Serialize(BigEndianWriter writer)
{

guildInfo.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

guildInfo = new Types.BasicGuildInformations();
            guildInfo.Deserialize(reader);
            

}


}


}