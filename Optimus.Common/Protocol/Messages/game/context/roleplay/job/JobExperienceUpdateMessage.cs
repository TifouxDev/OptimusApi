


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class JobExperienceUpdateMessage : NetworkMessage
{

public const uint Id = 5654;
public override uint MessageId
{
    get { return Id; }
}

public Types.JobExperience experiencesUpdate;
        

public JobExperienceUpdateMessage()
{
}

public JobExperienceUpdateMessage(Types.JobExperience experiencesUpdate)
        {
            this.experiencesUpdate = experiencesUpdate;
        }
        

public override void Serialize(BigEndianWriter writer)
{

experiencesUpdate.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

experiencesUpdate = new Types.JobExperience();
            experiencesUpdate.Deserialize(reader);
            

}


}


}