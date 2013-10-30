


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightSynchronizeMessage : NetworkMessage
{

public const uint Id = 5921;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameFightFighterInformations[] fighters;
        

public GameFightSynchronizeMessage()
{
}

public GameFightSynchronizeMessage(Types.GameFightFighterInformations[] fighters)
        {
            this.fighters = fighters;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)fighters.Length);
            foreach (var entry in fighters)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            fighters = new Types.GameFightFighterInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 fighters[i] = Types.ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadShort());
                 fighters[i].Deserialize(reader);
            }
            

}


}


}