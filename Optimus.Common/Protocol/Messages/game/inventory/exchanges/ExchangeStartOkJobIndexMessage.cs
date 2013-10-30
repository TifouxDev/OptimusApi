


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeStartOkJobIndexMessage : NetworkMessage
{

public const uint Id = 5819;
public override uint MessageId
{
    get { return Id; }
}

public int[] jobs;
        

public ExchangeStartOkJobIndexMessage()
{
}

public ExchangeStartOkJobIndexMessage(int[] jobs)
        {
            this.jobs = jobs;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)jobs.Length);
            foreach (var entry in jobs)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            jobs = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 jobs[i] = reader.ReadInt();
            }
            

}


}


}