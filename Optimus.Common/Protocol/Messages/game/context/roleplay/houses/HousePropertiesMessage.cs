


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class HousePropertiesMessage : NetworkMessage
{

public const uint Id = 5734;
public override uint MessageId
{
    get { return Id; }
}

public Types.HouseInformations properties;
        

public HousePropertiesMessage()
{
}

public HousePropertiesMessage(Types.HouseInformations properties)
        {
            this.properties = properties;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(properties.TypeId);
            properties.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

properties = Types.ProtocolTypeManager.GetInstance<Types.HouseInformations>(reader.ReadShort());
            properties.Deserialize(reader);
            

}


}


}