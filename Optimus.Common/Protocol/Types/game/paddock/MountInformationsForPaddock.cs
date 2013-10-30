


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class MountInformationsForPaddock
{

public const short Id = 184;
public virtual short TypeId
{
    get { return Id; }
}

public int modelId;
        public string name;
        public string ownerName;
        

public MountInformationsForPaddock()
{
}

public MountInformationsForPaddock(int modelId, string name, string ownerName)
        {
            this.modelId = modelId;
            this.name = name;
            this.ownerName = ownerName;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteInt(modelId);
            writer.WriteUTF(name);
            writer.WriteUTF(ownerName);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

modelId = reader.ReadInt();
            name = reader.ReadUTF();
            ownerName = reader.ReadUTF();
            

}


}


}