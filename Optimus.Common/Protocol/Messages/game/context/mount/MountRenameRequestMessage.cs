


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MountRenameRequestMessage : NetworkMessage
{

public const uint Id = 5987;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public double mountId;
        

public MountRenameRequestMessage()
{
}

public MountRenameRequestMessage(string name, double mountId)
        {
            this.name = name;
            this.mountId = mountId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(name);
            writer.WriteDouble(mountId);
            

}

public override void Deserialize(BigEndianReader reader)
{

name = reader.ReadUTF();
            mountId = reader.ReadDouble();
            

}


}


}