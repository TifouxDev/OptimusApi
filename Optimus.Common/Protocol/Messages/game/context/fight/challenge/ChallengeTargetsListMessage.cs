


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ChallengeTargetsListMessage : NetworkMessage
{

public const uint Id = 5613;
public override uint MessageId
{
    get { return Id; }
}

public int[] targetIds;
        public short[] targetCells;
        

public ChallengeTargetsListMessage()
{
}

public ChallengeTargetsListMessage(int[] targetIds, short[] targetCells)
        {
            this.targetIds = targetIds;
            this.targetCells = targetCells;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)targetIds.Length);
            foreach (var entry in targetIds)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteUShort((ushort)targetCells.Length);
            foreach (var entry in targetCells)
            {
                 writer.WriteShort(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            targetIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 targetIds[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            targetCells = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 targetCells[i] = reader.ReadShort();
            }
            

}


}


}