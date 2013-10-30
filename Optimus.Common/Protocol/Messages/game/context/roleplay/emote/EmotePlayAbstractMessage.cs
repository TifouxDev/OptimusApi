


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class EmotePlayAbstractMessage : NetworkMessage
{

public const uint Id = 5690;
public override uint MessageId
{
    get { return Id; }
}

public sbyte emoteId;
        public double emoteStartTime;
        

public EmotePlayAbstractMessage()
{
}

public EmotePlayAbstractMessage(sbyte emoteId, double emoteStartTime)
        {
            this.emoteId = emoteId;
            this.emoteStartTime = emoteStartTime;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(emoteId);
            writer.WriteDouble(emoteStartTime);
            

}

public override void Deserialize(BigEndianReader reader)
{

emoteId = reader.ReadSByte();
            if (emoteId < 0)
                throw new Exception("Forbidden value on emoteId = " + emoteId + ", it doesn't respect the following condition : emoteId < 0");
            emoteStartTime = reader.ReadDouble();
            

}


}


}