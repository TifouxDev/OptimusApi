


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceModificationNameAndTagValidMessage : NetworkMessage
{

public const uint Id = 6449;
public override uint MessageId
{
    get { return Id; }
}

public string allianceName;
        public string allianceTag;
        

public AllianceModificationNameAndTagValidMessage()
{
}

public AllianceModificationNameAndTagValidMessage(string allianceName, string allianceTag)
        {
            this.allianceName = allianceName;
            this.allianceTag = allianceTag;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(allianceName);
            writer.WriteUTF(allianceTag);
            

}

public override void Deserialize(BigEndianReader reader)
{

allianceName = reader.ReadUTF();
            allianceTag = reader.ReadUTF();
            

}


}


}