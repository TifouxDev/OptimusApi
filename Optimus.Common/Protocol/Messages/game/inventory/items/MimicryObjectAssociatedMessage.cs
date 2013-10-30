


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MimicryObjectAssociatedMessage : NetworkMessage
{

public const uint Id = 6462;
public override uint MessageId
{
    get { return Id; }
}

public int hostUID;
        

public MimicryObjectAssociatedMessage()
{
}

public MimicryObjectAssociatedMessage(int hostUID)
        {
            this.hostUID = hostUID;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(hostUID);
            

}

public override void Deserialize(BigEndianReader reader)
{

hostUID = reader.ReadInt();
            if (hostUID < 0)
                throw new Exception("Forbidden value on hostUID = " + hostUID + ", it doesn't respect the following condition : hostUID < 0");
            

}


}


}