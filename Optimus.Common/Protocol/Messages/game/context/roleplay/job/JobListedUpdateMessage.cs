


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class JobListedUpdateMessage : NetworkMessage
{

public const uint Id = 6016;
public override uint MessageId
{
    get { return Id; }
}

public bool addedOrDeleted;
        public sbyte jobId;
        

public JobListedUpdateMessage()
{
}

public JobListedUpdateMessage(bool addedOrDeleted, sbyte jobId)
        {
            this.addedOrDeleted = addedOrDeleted;
            this.jobId = jobId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(addedOrDeleted);
            writer.WriteSByte(jobId);
            

}

public override void Deserialize(BigEndianReader reader)
{

addedOrDeleted = reader.ReadBoolean();
            jobId = reader.ReadSByte();
            if (jobId < 0)
                throw new Exception("Forbidden value on jobId = " + jobId + ", it doesn't respect the following condition : jobId < 0");
            

}


}


}