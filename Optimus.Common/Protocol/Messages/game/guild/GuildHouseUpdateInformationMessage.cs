


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildHouseUpdateInformationMessage : NetworkMessage
{

public const uint Id = 6181;
public override uint MessageId
{
    get { return Id; }
}

public Types.HouseInformationsForGuild housesInformations;
        

public GuildHouseUpdateInformationMessage()
{
}

public GuildHouseUpdateInformationMessage(Types.HouseInformationsForGuild housesInformations)
        {
            this.housesInformations = housesInformations;
        }
        

public override void Serialize(BigEndianWriter writer)
{

housesInformations.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

housesInformations = new Types.HouseInformationsForGuild();
            housesInformations.Deserialize(reader);
            

}


}


}