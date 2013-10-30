


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MountDataMessage : NetworkMessage
{

public const uint Id = 5973;
public override uint MessageId
{
    get { return Id; }
}

public Types.MountClientData mountData;
        

public MountDataMessage()
{
}

public MountDataMessage(Types.MountClientData mountData)
        {
            this.mountData = mountData;
        }
        

public override void Serialize(BigEndianWriter writer)
{

mountData.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

mountData = new Types.MountClientData();
            mountData.Deserialize(reader);
            

}


}


}