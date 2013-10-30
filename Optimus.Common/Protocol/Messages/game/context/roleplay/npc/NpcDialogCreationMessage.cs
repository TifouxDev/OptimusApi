


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class NpcDialogCreationMessage : NetworkMessage
{

public const uint Id = 5618;
public override uint MessageId
{
    get { return Id; }
}

public int mapId;
        public int npcId;
        

public NpcDialogCreationMessage()
{
}

public NpcDialogCreationMessage(int mapId, int npcId)
        {
            this.mapId = mapId;
            this.npcId = npcId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(mapId);
            writer.WriteInt(npcId);
            

}

public override void Deserialize(BigEndianReader reader)
{

mapId = reader.ReadInt();
            npcId = reader.ReadInt();
            

}


}


}