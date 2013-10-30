


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class SetCharacterRestrictionsMessage : NetworkMessage
{

public const uint Id = 170;
public override uint MessageId
{
    get { return Id; }
}

public Types.ActorRestrictionsInformations restrictions;
        

public SetCharacterRestrictionsMessage()
{
}

public SetCharacterRestrictionsMessage(Types.ActorRestrictionsInformations restrictions)
        {
            this.restrictions = restrictions;
        }
        

public override void Serialize(BigEndianWriter writer)
{

restrictions.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

restrictions = new Types.ActorRestrictionsInformations();
            restrictions.Deserialize(reader);
            

}


}


}