


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ChatAbstractServerMessage : NetworkMessage
{

public const uint Id = 880;
public override uint MessageId
{
    get { return Id; }
}

public sbyte channel;
        public string content;
        public int timestamp;
        public string fingerprint;
        

public ChatAbstractServerMessage()
{
}

public ChatAbstractServerMessage(sbyte channel, string content, int timestamp, string fingerprint)
        {
            this.channel = channel;
            this.content = content;
            this.timestamp = timestamp;
            this.fingerprint = fingerprint;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(channel);
            writer.WriteUTF(content);
            writer.WriteInt(timestamp);
            writer.WriteUTF(fingerprint);
            

}

public override void Deserialize(BigEndianReader reader)
{

channel = reader.ReadSByte();
            if (channel < 0)
                throw new Exception("Forbidden value on channel = " + channel + ", it doesn't respect the following condition : channel < 0");
            content = reader.ReadUTF();
            timestamp = reader.ReadInt();
            if (timestamp < 0)
                throw new Exception("Forbidden value on timestamp = " + timestamp + ", it doesn't respect the following condition : timestamp < 0");
            fingerprint = reader.ReadUTF();
            

}


}


}