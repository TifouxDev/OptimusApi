


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ChatAbstractClientMessage : NetworkMessage
{

public const uint Id = 850;
public override uint MessageId
{
    get { return Id; }
}

public string content;
        

public ChatAbstractClientMessage()
{
}

public ChatAbstractClientMessage(string content)
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