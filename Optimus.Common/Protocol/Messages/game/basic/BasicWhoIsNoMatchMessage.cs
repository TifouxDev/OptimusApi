


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class BasicWhoIsNoMatchMessage : NetworkMessage
{

public const uint Id = 179;
public override uint MessageId
{
    get { return Id; }
}

public string search;
        

public BasicWhoIsNoMatchMessage()
{
}

public BasicWhoIsNoMatchMessage(string search)
        {
            this.search = search;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(search);
            

}

public override void Deserialize(BigEndianReader reader)
{

search = reader.ReadUTF();
            

}


}


}