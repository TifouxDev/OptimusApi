


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameEntityDispositionMessage : NetworkMessage
{

public const uint Id = 5693;
public override uint MessageId
{
    get { return Id; }
}

public Types.IdentifiedEntityDispositionInformations disposition;
        

public GameEntityDispositionMessage()
{
}

public GameEntityDispositionMessage(Types.IdentifiedEntityDispositionInformations disposition)
        {
            this.disposition = disposition;
        }
        

public override void Serialize(BigEndianWriter writer)
{

disposition.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

disposition = new Types.IdentifiedEntityDispositionInformations();
            disposition.Deserialize(reader);
            

}


}


}