


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ChannelEnablingMessage : NetworkMessage
{

public const uint Id = 890;
public override uint MessageId
{
    get { return Id; }
}

public sbyte channel;
        public bool enable;
        

public ChannelEnablingMessage()
{
}

public ChannelEnablingMessage(sbyte channel, bool enable)
        {
            this.channel = channel;
            this.enable = enable;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(channel);
            writer.WriteBoolean(enable);
            

}

public override void Deserialize(BigEndianReader reader)
{

channel = reader.ReadSByte();
            if (channel < 0)
                throw new Exception("Forbidden value on channel = " + channel + ", it doesn't respect the following condition : channel < 0");
            enable = reader.ReadBoolean();
            

}


}


}