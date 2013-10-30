


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AdminCommandMessage : NetworkMessage
{

public const uint Id = 76;
public override uint MessageId
{
    get { return Id; }
}

public string content;
        

public AdminCommandMessage()
{
}

public AdminCommandMessage(string content)
        {
            this.content = content;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(content);
            

}

public override void Deserialize(BigEndianReader reader)
{

content = reader.ReadUTF();
            

}


}


}