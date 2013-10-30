


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class SpouseInformationsMessage : NetworkMessage
{

public const uint Id = 6356;
public override uint MessageId
{
    get { return Id; }
}

public Types.FriendSpouseInformations spouse;
        

public SpouseInformationsMessage()
{
}

public SpouseInformationsMessage(Types.FriendSpouseInformations spouse)
        {
            this.spouse = spouse;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(spouse.TypeId);
            spouse.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

spouse = Types.ProtocolTypeManager.GetInstance<Types.FriendSpouseInformations>(reader.ReadShort());
            spouse.Deserialize(reader);
            

}


}


}