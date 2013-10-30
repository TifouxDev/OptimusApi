


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class GameRolePlayNpcQuestFlag
{

public const short Id = 384;
public virtual short TypeId
{
    get { return Id; }
}

public short[] questsToValidId;
        public short[] questsToStartId;
        

public GameRolePlayNpcQuestFlag()
{
}

public GameRolePlayNpcQuestFlag(short[] questsToValidId, short[] questsToStartId)
        {
            this.questsToValidId = questsToValidId;
            this.questsToStartId = questsToStartId;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)questsToValidId.Length);
            foreach (var entry in questsToValidId)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteUShort((ushort)questsToStartId.Length);
            foreach (var entry in questsToStartId)
            {
                 writer.WriteShort(entry);
            }
            

}

public virtual void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            questsToValidId = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 questsToValidId[i] = reader.ReadShort();
            }
            limit = reader.ReadUShort();
            questsToStartId = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 questsToStartId[i] = reader.ReadShort();
            }
            

}


}


}