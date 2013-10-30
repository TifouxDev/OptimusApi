


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class JobLevelUpMessage : NetworkMessage
{

public const uint Id = 5656;
public override uint MessageId
{
    get { return Id; }
}

public sbyte newLevel;
        public Types.JobDescription jobsDescription;
        

public JobLevelUpMessage()
{
}

public JobLevelUpMessage(sbyte newLevel, Types.JobDescription jobsDescription)
        {
            this.newLevel = newLevel;
            this.jobsDescription = jobsDescription;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(newLevel);
            jobsDescription.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

newLevel = reader.ReadSByte();
            if (newLevel < 0)
                throw new Exception("Forbidden value on newLevel = " + newLevel + ", it doesn't respect the following condition : newLevel < 0");
            jobsDescription = new Types.JobDescription();
            jobsDescription.Deserialize(reader);
            

}


}


}