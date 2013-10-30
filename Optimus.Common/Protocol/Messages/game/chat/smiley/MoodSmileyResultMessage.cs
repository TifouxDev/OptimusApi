


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MoodSmileyResultMessage : NetworkMessage
{

public const uint Id = 6196;
public override uint MessageId
{
    get { return Id; }
}

public sbyte resultCode;
        public sbyte smileyId;
        

public MoodSmileyResultMessage()
{
}

public MoodSmileyResultMessage(sbyte resultCode, sbyte smileyId)
        {
            this.resultCode = resultCode;
            this.smileyId = smileyId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(resultCode);
            writer.WriteSByte(smileyId);
            

}

public override void Deserialize(BigEndianReader reader)
{

resultCode = reader.ReadSByte();
            if (resultCode < 0)
                throw new Exception("Forbidden value on resultCode = " + resultCode + ", it doesn't respect the following condition : resultCode < 0");
            smileyId = reader.ReadSByte();
            

}


}


}