


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ChatClientPrivateMessage : ChatAbstractClientMessage
{

public const uint Id = 851;
public override uint MessageId
{
    get { return Id; }
}

public string receiver;
        

public ChatClientPrivateMessage()
{
}

public ChatClientPrivateMessage(string content, string receiver)
         : base(content)
        {
            this.receiver = receiver;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(receiver);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            receiver = reader.ReadUTF();
            

}


}


}