


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MapRunningFightDetailsMessage : NetworkMessage
{

public const uint Id = 5751;
public override uint MessageId
{
    get { return Id; }
}

public int fightId;
        public Types.GameFightFighterLightInformations[] attackers;
        public Types.GameFightFighterLightInformations[] defenders;
        

public MapRunningFightDetailsMessage()
{
}

public MapRunningFightDetailsMessage(int fightId, Types.GameFightFighterLightInformations[] attackers, Types.GameFightFighterLightInformations[] defenders)
        {
            this.fightId = fightId;
            this.attackers = attackers;
            this.defenders = defenders;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteUShort((ushort)attackers.Length);
            foreach (var entry in attackers)
            {
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)defenders.Length);
            foreach (var entry in defenders)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

fightId = reader.ReadInt();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            var limit = reader.ReadUShort();
            attackers = new Types.GameFightFighterLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 attackers[i] = new Types.GameFightFighterLightInformations();
                 attackers[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            defenders = new Types.GameFightFighterLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 defenders[i] = new Types.GameFightFighterLightInformations();
                 defenders[i].Deserialize(reader);
            }
            

}


}


}