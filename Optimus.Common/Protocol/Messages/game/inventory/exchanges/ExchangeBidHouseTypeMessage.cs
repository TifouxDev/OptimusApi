


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeBidHouseTypeMessage : NetworkMessage
{

public const uint Id = 5803;
public override uint MessageId
{
    get { return Id; }
}

public int type;
        

public ExchangeBidHouseTypeMessage()
{
}

public ExchangeBidHouseTypeMessage(int type)
        {
            this.type = type;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(type);
            

}

public override void Deserialize(BigEndianReader reader)
{

type = reader.ReadInt();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            

}


}


}