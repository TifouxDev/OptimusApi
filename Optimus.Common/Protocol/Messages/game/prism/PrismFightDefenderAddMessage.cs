


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PrismFightDefenderAddMessage : NetworkMessage
{

public const uint Id = 5895;
public override uint MessageId
{
    get { return Id; }
}

public short subAreaId;
        public double fightId;
        public Types.CharacterMinimalPlusLookInformations defender;
        

public PrismFightDefenderAddMessage()
{
}

public PrismFightDefenderAddMessage(short subAreaId, double fightId, Types.CharacterMinimalPlusLookInformations defender)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.defender = defender;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(subAreaId);
            writer.WriteDouble(fightId);
            writer.WriteShort(defender.TypeId);
            defender.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

subAreaId = reader.ReadShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            fightId = reader.ReadDouble();
            defender = Types.ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadShort());
            defender.Deserialize(reader);
            

}


}


}