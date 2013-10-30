


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class BasicTimeMessage : NetworkMessage
{

public const uint Id = 175;
public override uint MessageId
{
    get { return Id; }
}

public int timestamp;
        public short timezoneOffset;
        

public BasicTimeMessage()
{
}

public BasicTimeMessage(int timestamp, short timezoneOffset)
        {
            this.timestamp = timestamp;
            this.timezoneOffset = timezoneOffset;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(timestamp);
            writer.WriteShort(timezoneOffset);
            

}

public override void Deserialize(BigEndianReader reader)
{

timestamp = reader.ReadInt();
            if (timestamp < 0)
                throw new Exception("Forbidden value on timestamp = " + timestamp + ", it doesn't respect the following condition : timestamp < 0");
            timezoneOffset = reader.ReadShort();
            

}


}


}