


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class BasicWhoIsRequestMessage : NetworkMessage
{

public const uint Id = 181;
public override uint MessageId
{
    get { return Id; }
}

public bool verbose;
        public string search;
        

public BasicWhoIsRequestMessage()
{
}

public BasicWhoIsRequestMessage(bool verbose, string search)
        {
            this.verbose = verbose;
            this.search = search;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(verbose);
            writer.WriteUTF(search);
            

}

public override void Deserialize(BigEndianReader reader)
{

verbose = reader.ReadBoolean();
            search = reader.ReadUTF();
            

}


}


}