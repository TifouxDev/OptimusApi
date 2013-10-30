


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceKickRequestMessage : NetworkMessage
{

public const uint Id = 6400;
public override uint MessageId
{
    get { return Id; }
}

public int kickedId;
        

public AllianceKickRequestMessage()
{
}

public AllianceKickRequestMessage(int kickedId)
        {
            this.kickedId = kickedId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(kickedId);
            

}

public override void Deserialize(BigEndianReader reader)
{

kickedId = reader.ReadInt();
            if (kickedId < 0)
                throw new Exception("Forbidden value on kickedId = " + kickedId + ", it doesn't respect the following condition : kickedId < 0");
            

}


}


}