


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ChatClientMultiMessage : ChatAbstractClientMessage
{

public const uint Id = 861;
public override uint MessageId
{
    get { return Id; }
}

public sbyte channel;
        

public ChatClientMultiMessage()
{
}

public ChatClientMultiMessage(string content, sbyte channel)
         : base(content)
        {
            this.channel = channel;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(channel);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            channel = reader.ReadSByte();
            if (channel < 0)
                throw new Exception("Forbidden value on channel = " + channel + ", it doesn't respect the following condition : channel < 0");
            

}


}


}