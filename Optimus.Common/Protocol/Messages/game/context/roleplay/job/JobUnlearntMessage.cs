


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class JobUnlearntMessage : NetworkMessage
{

public const uint Id = 5657;
public override uint MessageId
{
    get { return Id; }
}

public sbyte jobId;
        

public JobUnlearntMessage()
{
}

public JobUnlearntMessage(sbyte jobId)
        {
            this.jobId = jobId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(jobId);
            

}

public override void Deserialize(BigEndianReader reader)
{

jobId = reader.ReadSByte();
            if (jobId < 0)
                throw new Exception("Forbidden value on jobId = " + jobId + ", it doesn't respect the following condition : jobId < 0");
            

}


}


}