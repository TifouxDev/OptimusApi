


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PrismFightAddedMessage : NetworkMessage
{

public const uint Id = 6452;
public override uint MessageId
{
    get { return Id; }
}

public Types.PrismFightersInformation fight;
        

public PrismFightAddedMessage()
{
}

public PrismFightAddedMessage(Types.PrismFightersInformation fight)
        {
            this.fight = fight;
        }
        

public override void Serialize(BigEndianWriter writer)
{

fight.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

fight = new Types.PrismFightersInformation();
            fight.Deserialize(reader);
            

}


}


}