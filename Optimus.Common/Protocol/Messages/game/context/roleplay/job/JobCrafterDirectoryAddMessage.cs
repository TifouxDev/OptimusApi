


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class JobCrafterDirectoryAddMessage : NetworkMessage
{

public const uint Id = 5651;
public override uint MessageId
{
    get { return Id; }
}

public Types.JobCrafterDirectoryListEntry listEntry;
        

public JobCrafterDirectoryAddMessage()
{
}

public JobCrafterDirectoryAddMessage(Types.JobCrafterDirectoryListEntry listEntry)
        {
            this.listEntry = listEntry;
        }
        

public override void Serialize(BigEndianWriter writer)
{

listEntry.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

listEntry = new Types.JobCrafterDirectoryListEntry();
            listEntry.Deserialize(reader);
            

}


}


}