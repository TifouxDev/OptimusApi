


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameDataPlayFarmObjectAnimationMessage : NetworkMessage
{

public const uint Id = 6026;
public override uint MessageId
{
    get { return Id; }
}

public short[] cellId;
        

public GameDataPlayFarmObjectAnimationMessage()
{
}

public GameDataPlayFarmObjectAnimationMessage(short[] cellId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)cellId.Length);
            foreach (var entry in cellId)
            {
                 writer.WriteShort(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            cellId = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 cellId[i] = reader.ReadShort();
            }
            

}


}


}