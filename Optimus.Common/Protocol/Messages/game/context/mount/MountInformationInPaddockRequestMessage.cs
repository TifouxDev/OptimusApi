


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MountInformationInPaddockRequestMessage : NetworkMessage
{

public const uint Id = 5975;
public override uint MessageId
{
    get { return Id; }
}

public int mapRideId;
        

public MountInformationInPaddockRequestMessage()
{
}

public MountInformationInPaddockRequestMessage(int mapRideId)
        {
            this.mapRideId = mapRideId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(mapRideId);
            

}

public override void Deserialize(BigEndianReader reader)
{

mapRideId = reader.ReadInt();
            

}


}


}