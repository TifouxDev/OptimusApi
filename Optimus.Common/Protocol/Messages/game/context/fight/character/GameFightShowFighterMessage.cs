


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightShowFighterMessage : NetworkMessage
{

public const uint Id = 5864;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameFightFighterInformations informations;
        

public GameFightShowFighterMessage()
{
}

public GameFightShowFighterMessage(Types.GameFightFighterInformations informations)
        {
            this.informations = informations;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(informations.TypeId);
            informations.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

informations = Types.ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadShort());
            informations.Deserialize(reader);
            

}


}


}