


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class UpdateMapPlayersAgressableStatusMessage : NetworkMessage
{

public const uint Id = 6454;
public override uint MessageId
{
    get { return Id; }
}

public int[] playerIds;
        public sbyte[] enable;
        

public UpdateMapPlayersAgressableStatusMessage()
{
}

public UpdateMapPlayersAgressableStatusMessage(int[] playerIds, sbyte[] enable)
        {
            this.playerIds = playerIds;
            this.enable = enable;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)playerIds.Length);
            foreach (var entry in playerIds)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteUShort((ushort)enable.Length);
            foreach (var entry in enable)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            playerIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 playerIds[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            enable = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 enable[i] = reader.ReadSByte();
            }
            

}


}


}