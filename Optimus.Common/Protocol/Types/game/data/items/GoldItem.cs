


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class GoldItem : Item
{

public const short Id = 123;
public override short TypeId
{
    get { return Id; }
}

public int sum;
        

public GoldItem()
{
}

public GoldItem(int sum)
        {
            this.sum = sum;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(sum);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            sum = reader.ReadInt();
            if (sum < 0)
                throw new Exception("Forbidden value on sum = " + sum + ", it doesn't respect the following condition : sum < 0");
            

}


}


}