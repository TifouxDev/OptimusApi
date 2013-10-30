


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CinematicMessage : NetworkMessage
{

public const uint Id = 6053;
public override uint MessageId
{
    get { return Id; }
}

public short cinematicId;
        

public CinematicMessage()
{
}

public CinematicMessage(short cinematicId)
        {
            this.cinematicId = cinematicId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(cinematicId);
            

}

public override void Deserialize(BigEndianReader reader)
{

cinematicId = reader.ReadShort();
            if (cinematicId < 0)
                throw new Exception("Forbidden value on cinematicId = " + cinematicId + ", it doesn't respect the following condition : cinematicId < 0");
            

}


}


}