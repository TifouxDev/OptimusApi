


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeBidHouseBuyResultMessage : NetworkMessage
{

public const uint Id = 6272;
public override uint MessageId
{
    get { return Id; }
}

public int uid;
        public bool bought;
        

public ExchangeBidHouseBuyResultMessage()
{
}

public ExchangeBidHouseBuyResultMessage(int uid, bool bought)
        {
            this.uid = uid;
            this.bought = bought;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(uid);
            writer.WriteBoolean(bought);
            

}

public override void Deserialize(BigEndianReader reader)
{

uid = reader.ReadInt();
            if (uid < 0)
                throw new Exception("Forbidden value on uid = " + uid + ", it doesn't respect the following condition : uid < 0");
            bought = reader.ReadBoolean();
            

}


}


}