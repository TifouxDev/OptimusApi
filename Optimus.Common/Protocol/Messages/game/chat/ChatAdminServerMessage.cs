


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ChatAdminServerMessage : ChatServerMessage
{

public const uint Id = 6135;
public override uint MessageId
{
    get { return Id; }
}



public ChatAdminServerMessage()
{
}

public ChatAdminServerMessage(sbyte channel, string content, int timestamp, string fingerprint, int senderId, string senderName, int senderAccountId)
         : base(channel, content, timestamp, fingerprint, senderId, senderName, senderAccountId)
        {
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            

}


}


}