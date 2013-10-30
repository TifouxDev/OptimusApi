


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class BasicWhoAmIRequestMessage : NetworkMessage
{

public const uint Id = 5664;
public override uint MessageId
{
    get { return Id; }
}

public bool verbose;
        

public BasicWhoAmIRequestMessage()
{
}

public BasicWhoAmIRequestMessage(bool verbose)
        {
            this.verbose = verbose;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(verbose);
            

}

public override void Deserialize(BigEndianReader reader)
{

verbose = reader.ReadBoolean();
            

}


}


}