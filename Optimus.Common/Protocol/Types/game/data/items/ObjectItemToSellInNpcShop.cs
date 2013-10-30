


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ObjectItemToSellInNpcShop : ObjectItemMinimalInformation
{

public const short Id = 352;
public override short TypeId
{
    get { return Id; }
}

public int objectPrice;
        public string buyCriterion;
        

public ObjectItemToSellInNpcShop()
{
}

public ObjectItemToSellInNpcShop(short objectGID, Types.ObjectEffect[] effects, int objectPrice, string buyCriterion)
         : base(objectGID, effects)
        {
            this.objectPrice = objectPrice;
            this.buyCriterion = buyCriterion;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(objectPrice);
            writer.WriteUTF(buyCriterion);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            objectPrice = reader.ReadInt();
            if (objectPrice < 0)
                throw new Exception("Forbidden value on objectPrice = " + objectPrice + ", it doesn't respect the following condition : objectPrice < 0");
            buyCriterion = reader.ReadUTF();
            

}


}


}