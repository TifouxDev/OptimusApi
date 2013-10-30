


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class DungeonPartyFinderRegisterSuccessMessage : NetworkMessage
{

public const uint Id = 6241;
public override uint MessageId
{
    get { return Id; }
}

public short[] dungeonIds;
        

public DungeonPartyFinderRegisterSuccessMessage()
{
}

public DungeonPartyFinderRegisterSuccessMessage(short[] dungeonIds)
        {
            this.dungeonIds = dungeonIds;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)dungeonIds.Length);
            foreach (var entry in dungeonIds)
            {
                 writer.WriteShort(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            dungeonIds = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 dungeonIds[i] = reader.ReadShort();
            }
            

}


}


}