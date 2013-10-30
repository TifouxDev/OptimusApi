


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ObjectGroundRemovedMessage : NetworkMessage
{

public const uint Id = 3014;
public override uint MessageId
{
    get { return Id; }
}

public short cell;
        

public ObjectGroundRemovedMessage()
{
}

public ObjectGroundRemovedMessage(short cell)
        {
            this.cell = cell;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(cell);
            

}

public override void Deserialize(BigEndianReader reader)
{

cell = reader.ReadShort();
            if (cell < 0 || cell > 559)
                throw new Exception("Forbidden value on cell = " + cell + ", it doesn't respect the following condition : cell < 0 || cell > 559");
            

}


}


}