


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameMapChangeOrientationMessage : NetworkMessage
{

public const uint Id = 946;
public override uint MessageId
{
    get { return Id; }
}

public Types.ActorOrientation orientation;
        

public GameMapChangeOrientationMessage()
{
}

public GameMapChangeOrientationMessage(Types.ActorOrientation orientation)
        {
            this.orientation = orientation;
        }
        

public override void Serialize(BigEndianWriter writer)
{

orientation.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

orientation = new Types.ActorOrientation();
            orientation.Deserialize(reader);
            

}


}


}