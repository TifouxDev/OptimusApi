


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ServerExperienceModificatorMessage : NetworkMessage
{

public const uint Id = 6237;
public override uint MessageId
{
    get { return Id; }
}

public short experiencePercent;
        

public ServerExperienceModificatorMessage()
{
}

public ServerExperienceModificatorMessage(short experiencePercent)
        {
            this.experiencePercent = experiencePercent;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(experiencePercent);
            

}

public override void Deserialize(BigEndianReader reader)
{

experiencePercent = reader.ReadShort();
            if (experiencePercent < 0)
                throw new Exception("Forbidden value on experiencePercent = " + experiencePercent + ", it doesn't respect the following condition : experiencePercent < 0");
            

}


}


}