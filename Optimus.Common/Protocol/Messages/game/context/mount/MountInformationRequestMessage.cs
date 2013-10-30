


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MountInformationRequestMessage : NetworkMessage
{

public const uint Id = 5972;
public override uint MessageId
{
    get { return Id; }
}

public double id;
        public double time;
        

public MountInformationRequestMessage()
{
}

public MountInformationRequestMessage(double id, double time)
        {
            this.id = id;
            this.time = time;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteDouble(id);
            writer.WriteDouble(time);
            

}

public override void Deserialize(BigEndianReader reader)
{

id = reader.ReadDouble();
            time = reader.ReadDouble();
            

}


}


}