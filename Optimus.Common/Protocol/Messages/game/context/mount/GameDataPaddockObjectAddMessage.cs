


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameDataPaddockObjectAddMessage : NetworkMessage
{

public const uint Id = 5990;
public override uint MessageId
{
    get { return Id; }
}

public Types.PaddockItem paddockItemDescription;
        

public GameDataPaddockObjectAddMessage()
{
}

public GameDataPaddockObjectAddMessage(Types.PaddockItem paddockItemDescription)
        {
            this.paddockItemDescription = paddockItemDescription;
        }
        

public override void Serialize(BigEndianWriter writer)
{

paddockItemDescription.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

paddockItemDescription = new Types.PaddockItem();
            paddockItemDescription.Deserialize(reader);
            

}


}


}