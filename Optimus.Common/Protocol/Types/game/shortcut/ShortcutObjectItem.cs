


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ShortcutObjectItem : ShortcutObject
{

public const short Id = 371;
public override short TypeId
{
    get { return Id; }
}

public int itemUID;
        public int itemGID;
        

public ShortcutObjectItem()
{
}

public ShortcutObjectItem(int slot, int itemUID, int itemGID)
         : base(slot)
        {
            this.itemUID = itemUID;
            this.itemGID = itemGID;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(itemUID);
            writer.WriteInt(itemGID);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            itemUID = reader.ReadInt();
            itemGID = reader.ReadInt();
            

}


}


}