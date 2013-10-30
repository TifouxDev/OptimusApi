


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharacterSelectedSuccessMessage : NetworkMessage
{

public const uint Id = 153;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterBaseInformations infos;
        

public CharacterSelectedSuccessMessage()
{
}

public CharacterSelectedSuccessMessage(Types.CharacterBaseInformations infos)
        {
            this.infos = infos;
        }
        

public override void Serialize(BigEndianWriter writer)
{

infos.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

infos = new Types.CharacterBaseInformations();
            infos.Deserialize(reader);
            

}


}


}