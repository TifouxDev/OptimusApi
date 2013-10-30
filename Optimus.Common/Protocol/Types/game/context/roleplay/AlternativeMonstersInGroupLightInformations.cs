


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class AlternativeMonstersInGroupLightInformations
{

public const short Id = 394;
public virtual short TypeId
{
    get { return Id; }
}

public int playerCount;
        public Types.MonsterInGroupLightInformations[] monsters;
        

public AlternativeMonstersInGroupLightInformations()
{
}

public AlternativeMonstersInGroupLightInformations(int playerCount, Types.MonsterInGroupLightInformations[] monsters)
        {
            this.playerCount = playerCount;
            this.monsters = monsters;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteInt(playerCount);
            writer.WriteUShort((ushort)monsters.Length);
            foreach (var entry in monsters)
            {
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(BigEndianReader reader)
{

playerCount = reader.ReadInt();
            var limit = reader.ReadUShort();
            monsters = new Types.MonsterInGroupLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 monsters[i] = new Types.MonsterInGroupLightInformations();
                 monsters[i].Deserialize(reader);
            }
            

}


}


}