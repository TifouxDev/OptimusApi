


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightUnmarkCellsMessage : AbstractGameActionMessage
{

public const uint Id = 5570;
public override uint MessageId
{
    get { return Id; }
}

public short markId;
        

public GameActionFightUnmarkCellsMessage()
{
}

public GameActionFightUnmarkCellsMessage(short actionId, int sourceId, short markId)
         : base(actionId, sourceId)
        {
            this.markId = markId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(markId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            markId = reader.ReadShort();
            

}


}


}