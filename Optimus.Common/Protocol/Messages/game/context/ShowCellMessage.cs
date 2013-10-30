


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ShowCellMessage : NetworkMessage
{

public const uint Id = 5612;
public override uint MessageId
{
    get { return Id; }
}

public int sourceId;
        public short cellId;
        

public ShowCellMessage()
{
}

public ShowCellMessage(int sourceId, short cellId)
        {
            this.sourceId = sourceId;
            this.cellId = cellId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(sourceId);
            writer.WriteShort(cellId);
            

}

public override void Deserialize(BigEndianReader reader)
{

sourceId = reader.ReadInt();
            cellId = reader.ReadShort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            

}


}


}