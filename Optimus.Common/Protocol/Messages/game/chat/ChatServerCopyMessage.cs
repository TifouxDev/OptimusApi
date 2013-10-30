


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ChatServerCopyMessage : ChatAbstractServerMessage
{

public const uint Id = 882;
public override uint MessageId
{
    get { return Id; }
}

public int receiverId;
        public string receiverName;
        

public ChatServerCopyMessage()
{
}

public ChatServerCopyMessage(sbyte channel, string content, int timestamp, string fingerprint, int receiverId, string receiverName)
         : base(channel, content, timestamp, fingerprint)
        {
            this.receiverId = receiverId;
            this.receiverName = receiverName;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(receiverId);
            writer.WriteUTF(receiverName);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            receiverId = reader.ReadInt();
            if (receiverId < 0)
                throw new Exception("Forbidden value on receiverId = " + receiverId + ", it doesn't respect the following condition : receiverId < 0");
            receiverName = reader.ReadUTF();
            

}


}


}