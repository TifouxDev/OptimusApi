


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceFactsErrorMessage : NetworkMessage
{

public const uint Id = 6423;
public override uint MessageId
{
    get { return Id; }
}

public int allianceId;
        

public AllianceFactsErrorMessage()
{
}

public AllianceFactsErrorMessage(int allianceId)
        {
            this.allianceId = allianceId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(allianceId);
            

}

public override void Deserialize(BigEndianReader reader)
{

allianceId = reader.ReadInt();
            if (allianceId < 0)
                throw new Exception("Forbidden value on allianceId = " + allianceId + ", it doesn't respect the following condition : allianceId < 0");
            

}


}


}