


















// Generated on 10/27/2013 07:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightMarkCellsMessage : AbstractGameActionMessage
{

public const uint Id = 5540;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameActionMark mark;
        

public GameActionFightMarkCellsMessage()
{
}

public GameActionFightMarkCellsMessage(short actionId, int sourceId, Types.GameActionMark mark)
         : base(actionId, sourceId)
        {
            this.mark = mark;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            mark.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            mark = new Types.GameActionMark();
            mark.Deserialize(reader);
            

}


}


}