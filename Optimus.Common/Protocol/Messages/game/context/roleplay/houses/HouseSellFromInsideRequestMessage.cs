


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class HouseSellFromInsideRequestMessage : HouseSellRequestMessage
{

public const uint Id = 5884;
public override uint MessageId
{
    get { return Id; }
}



public HouseSellFromInsideRequestMessage()
{
}

public HouseSellFromInsideRequestMessage(int amount)
         : base(amount)
        {
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            

}


}


}