


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class HouseToSellListRequestMessage : NetworkMessage
{

public const uint Id = 6139;
public override uint MessageId
{
    get { return Id; }
}

public short pageIndex;
        

public HouseToSellListRequestMessage()
{
}

public HouseToSellListRequestMessage(short pageIndex)
        {
            this.pageIndex = pageIndex;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(pageIndex);
            

}

public override void Deserialize(BigEndianReader reader)
{

pageIndex = reader.ReadShort();
            if (pageIndex < 0)
                throw new Exception("Forbidden value on pageIndex = " + pageIndex + ", it doesn't respect the following condition : pageIndex < 0");
            

}


}


}