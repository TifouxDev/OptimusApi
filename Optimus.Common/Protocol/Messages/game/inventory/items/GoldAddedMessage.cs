


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GoldAddedMessage : NetworkMessage
{

public const uint Id = 6030;
public override uint MessageId
{
    get { return Id; }
}

public Types.GoldItem gold;
        

public GoldAddedMessage()
{
}

public GoldAddedMessage(Types.GoldItem gold)
        {
            this.gold = gold;
        }
        

public override void Serialize(BigEndianWriter writer)
{

gold.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

gold = new Types.GoldItem();
            gold.Deserialize(reader);
            

}


}


}