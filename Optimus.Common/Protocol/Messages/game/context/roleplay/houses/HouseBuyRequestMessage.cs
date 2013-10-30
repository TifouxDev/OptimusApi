


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class HouseBuyRequestMessage : NetworkMessage
{

public const uint Id = 5738;
public override uint MessageId
{
    get { return Id; }
}

public int proposedPrice;
        

public HouseBuyRequestMessage()
{
}

public HouseBuyRequestMessage(int proposedPrice)
        {
            this.proposedPrice = proposedPrice;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(proposedPrice);
            

}

public override void Deserialize(BigEndianReader reader)
{

proposedPrice = reader.ReadInt();
            if (proposedPrice < 0)
                throw new Exception("Forbidden value on proposedPrice = " + proposedPrice + ", it doesn't respect the following condition : proposedPrice < 0");
            

}


}


}