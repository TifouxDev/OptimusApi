


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class FighterStatsListMessage : NetworkMessage
{

public const uint Id = 6322;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterCharacteristicsInformations stats;
        

public FighterStatsListMessage()
{
}

public FighterStatsListMessage(Types.CharacterCharacteristicsInformations stats)
        {
            this.stats = stats;
        }
        

public override void Serialize(BigEndianWriter writer)
{

stats.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

stats = new Types.CharacterCharacteristicsInformations();
            stats.Deserialize(reader);
            

}


}


}