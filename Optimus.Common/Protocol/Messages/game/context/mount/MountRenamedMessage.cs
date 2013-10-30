


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MountRenamedMessage : NetworkMessage
{

public const uint Id = 5983;
public override uint MessageId
{
    get { return Id; }
}

public double mountId;
        public string name;
        

public MountRenamedMessage()
{
}

public MountRenamedMessage(double mountId, string name)
        {
            this.mountId = mountId;
            this.name = name;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteDouble(mountId);
            writer.WriteUTF(name);
            

}

public override void Deserialize(BigEndianReader reader)
{

mountId = reader.ReadDouble();
            name = reader.ReadUTF();
            

}


}


}