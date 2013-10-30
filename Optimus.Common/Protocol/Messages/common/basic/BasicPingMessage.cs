


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class BasicPingMessage : NetworkMessage
{

public const uint Id = 182;
public override uint MessageId
{
    get { return Id; }
}

public bool quiet;
        

public BasicPingMessage()
{
}

public BasicPingMessage(bool quiet)
        {
            this.quiet = quiet;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(quiet);
            

}

public override void Deserialize(BigEndianReader reader)
{

quiet = reader.ReadBoolean();
            

}


}


}