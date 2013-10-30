


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameRolePlayShowActorMessage : NetworkMessage
{

public const uint Id = 5632;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameRolePlayActorInformations informations;
        

public GameRolePlayShowActorMessage()
{
}

public GameRolePlayShowActorMessage(Types.GameRolePlayActorInformations informations)
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

informations = Types.ProtocolTypeManager.GetInstance<Types.GameRolePlayActorInformations>(reader.ReadShort());
            informations.Deserialize(reader);
            

}


}


}