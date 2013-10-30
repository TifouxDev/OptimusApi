


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ObjectGroundRemovedMultipleMessage : NetworkMessage
{

public const uint Id = 5944;
public override uint MessageId
{
    get { return Id; }
}

public short[] cells;
        

public ObjectGroundRemovedMultipleMessage()
{
}

public ObjectGroundRemovedMultipleMessage(short[] cells)
        {
            this.cells = cells;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)cells.Length);
            foreach (var entry in cells)
            {
                 writer.WriteShort(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            cells = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 cells[i] = reader.ReadShort();
            }
            

}


}


}