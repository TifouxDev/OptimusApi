


















// Generated on 10/27/2013 07:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class StorageKamasUpdateMessage : NetworkMessage
{

public const uint Id = 5645;
public override uint MessageId
{
    get { return Id; }
}

public int kamasTotal;
        

public StorageKamasUpdateMessage()
{
}

public StorageKamasUpdateMessage(int kamasTotal)
        {
            this.kamasTotal = kamasTotal;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(kamasTotal);
            

}

public override void Deserialize(BigEndianReader reader)
{

kamasTotal = reader.ReadInt();
            

}


}


}