


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ObjectItemInformationWithQuantity : ObjectItemMinimalInformation
{

public const short Id = 387;
public override short TypeId
{
    get { return Id; }
}

public int quantity;
        

public ObjectItemInformationWithQuantity()
{
}

public ObjectItemInformationWithQuantity(short objectGID, Types.ObjectEffect[] effects, int quantity)
         : base(objectGID, effects)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(quantity);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            quantity = reader.ReadInt();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}