


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ObjectItemToSellInBid : ObjectItemToSell
{

public const short Id = 164;
public override short TypeId
{
    get { return Id; }
}

public short unsoldDelay;
        

public ObjectItemToSellInBid()
{
}

public ObjectItemToSellInBid(short objectGID, Types.ObjectEffect[] effects, int objectUID, int quantity, int objectPrice, short unsoldDelay)
         : base(objectGID, effects, objectUID, quantity, objectPrice)
        {
            this.unsoldDelay = unsoldDelay;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(unsoldDelay);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            unsoldDelay = reader.ReadShort();
            if (unsoldDelay < 0)
                throw new Exception("Forbidden value on unsoldDelay = " + unsoldDelay + ", it doesn't respect the following condition : unsoldDelay < 0");
            

}


}


}