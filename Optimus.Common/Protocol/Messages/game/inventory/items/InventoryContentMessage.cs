


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class InventoryContentMessage : NetworkMessage
{

public const uint Id = 3016;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objects;
        public int kamas;
        

public InventoryContentMessage()
{
}

public InventoryContentMessage(Types.ObjectItem[] objects, int kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)objects.Length);
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
            writer.WriteInt(kamas);
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            objects = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = new Types.ObjectItem();
                 objects[i].Deserialize(reader);
            }
            kamas = reader.ReadInt();
            if (kamas < 0)
                throw new Exception("Forbidden value on kamas = " + kamas + ", it doesn't respect the following condition : kamas < 0");
            

}


}


}