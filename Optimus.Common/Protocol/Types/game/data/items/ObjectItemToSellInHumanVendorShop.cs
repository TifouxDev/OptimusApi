


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ObjectItemToSellInHumanVendorShop : Item
{

public const short Id = 359;
public override short TypeId
{
    get { return Id; }
}

public short objectGID;
        public Types.ObjectEffect[] effects;
        public int objectUID;
        public int quantity;
        public int objectPrice;
        public int publicPrice;
        

public ObjectItemToSellInHumanVendorShop()
{
}

public ObjectItemToSellInHumanVendorShop(short objectGID, Types.ObjectEffect[] effects, int objectUID, int quantity, int objectPrice, int publicPrice)
        {
            this.objectGID = objectGID;
            this.effects = effects;
            this.objectUID = objectUID;
            this.quantity = quantity;
            this.objectPrice = objectPrice;
            this.publicPrice = publicPrice;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(objectGID);
            writer.WriteUShort((ushort)effects.Length);
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteInt(objectUID);
            writer.WriteInt(quantity);
            writer.WriteInt(objectPrice);
            writer.WriteInt(publicPrice);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            objectGID = reader.ReadShort();
            if (objectGID < 0)
                throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            var limit = reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = Types.ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadShort());
                 effects[i].Deserialize(reader);
            }
            objectUID = reader.ReadInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            quantity = reader.ReadInt();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            objectPrice = reader.ReadInt();
            if (objectPrice < 0)
                throw new Exception("Forbidden value on objectPrice = " + objectPrice + ", it doesn't respect the following condition : objectPrice < 0");
            publicPrice = reader.ReadInt();
            if (publicPrice < 0)
                throw new Exception("Forbidden value on publicPrice = " + publicPrice + ", it doesn't respect the following condition : publicPrice < 0");
            

}


}


}