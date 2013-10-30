


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class BidExchangerObjectInfo
{

public const short Id = 122;
public virtual short TypeId
{
    get { return Id; }
}

public int objectUID;
        public Types.ObjectEffect[] effects;
        public int[] prices;
        

public BidExchangerObjectInfo()
{
}

public BidExchangerObjectInfo(int objectUID, Types.ObjectEffect[] effects, int[] prices)
        {
            this.objectUID = objectUID;
            this.effects = effects;
            this.prices = prices;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteInt(objectUID);
            writer.WriteUShort((ushort)effects.Length);
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)prices.Length);
            foreach (var entry in prices)
            {
                 writer.WriteInt(entry);
            }
            

}

public virtual void Deserialize(BigEndianReader reader)
{

objectUID = reader.ReadInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            var limit = reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = Types.ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadShort());
                 effects[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            prices = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 prices[i] = reader.ReadInt();
            }
            

}


}


}