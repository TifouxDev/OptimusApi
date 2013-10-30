


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PrismFightAttackerAddMessage : NetworkMessage
{

public const uint Id = 5893;
public override uint MessageId
{
    get { return Id; }
}

public short subAreaId;
        public double fightId;
        public Types.CharacterMinimalPlusLookInformations attacker;
        

public PrismFightAttackerAddMessage()
{
}

public PrismFightAttackerAddMessage(short subAreaId, double fightId, Types.CharacterMinimalPlusLookInformations attacker)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.attacker = attacker;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(subAreaId);
            writer.WriteDouble(fightId);
            writer.WriteShort(attacker.TypeId);
            attacker.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

subAreaId = reader.ReadShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            fightId = reader.ReadDouble();
            attacker = Types.ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadShort());
            attacker.Deserialize(reader);
            

}


}


}