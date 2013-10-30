


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeBidHouseBuyMessage : NetworkMessage
{

public const uint Id = 5804;
public override uint MessageId
{
    get { return Id; }
}

public int uid;
        public int qty;
        public int price;
        

public ExchangeBidHouseBuyMessage()
{
}

public ExchangeBidHouseBuyMessage(int uid, int qty, int price)
        {
            this.uid = uid;
            this.qty = qty;
            this.price = price;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(uid);
            writer.WriteInt(qty);
            writer.WriteInt(price);
            

}

public override void Deserialize(BigEndianReader reader)
{

uid = reader.ReadInt();
            if (uid < 0)
                throw new Exception("Forbidden value on uid = " + uid + ", it doesn't respect the following condition : uid < 0");
            qty = reader.ReadInt();
            if (qty < 0)
                throw new Exception("Forbidden value on qty = " + qty + ", it doesn't respect the following condition : qty < 0");
            price = reader.ReadInt();
            if (price < 0)
                throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            

}


}


}