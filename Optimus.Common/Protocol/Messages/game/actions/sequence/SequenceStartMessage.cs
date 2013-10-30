


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class SequenceStartMessage : NetworkMessage
{

public const uint Id = 955;
public override uint MessageId
{
    get { return Id; }
}

public sbyte sequenceType;
        public int authorId;
        

public SequenceStartMessage()
{
}

public SequenceStartMessage(sbyte sequenceType, int authorId)
        {
            this.sequenceType = sequenceType;
            this.authorId = authorId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(sequenceType);
            writer.WriteInt(authorId);
            

}

public override void Deserialize(BigEndianReader reader)
{

sequenceType = reader.ReadSByte();
            authorId = reader.ReadInt();
            

}


}


}