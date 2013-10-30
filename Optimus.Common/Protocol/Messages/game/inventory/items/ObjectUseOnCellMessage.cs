


















// Generated on 10/27/2013 07:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ObjectUseOnCellMessage : ObjectUseMessage
{

public const uint Id = 3013;
public override uint MessageId
{
    get { return Id; }
}

public short cells;
        

public ObjectUseOnCellMessage()
{
}

public ObjectUseOnCellMessage(int objectUID, short cells)
         : base(objectUID)
        {
            this.cells = cells;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(cells);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            cells = reader.ReadShort();
            if (cells < 0 || cells > 559)
                throw new Exception("Forbidden value on cells = " + cells + ", it doesn't respect the following condition : cells < 0 || cells > 559");
            

}


}


}