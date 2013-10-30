


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightSummonMessage : AbstractGameActionMessage
{

public const uint Id = 5825;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameFightFighterInformations summon;
        

public GameActionFightSummonMessage()
{
}

public GameActionFightSummonMessage(short actionId, int sourceId, Types.GameFightFighterInformations summon)
         : base(actionId, sourceId)
        {
            this.summon = summon;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(summon.TypeId);
            summon.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            summon = Types.ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadShort());
            summon.Deserialize(reader);
            

}


}


}