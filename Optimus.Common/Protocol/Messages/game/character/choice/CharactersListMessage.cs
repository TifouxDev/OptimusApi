


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharactersListMessage : NetworkMessage
{

public const uint Id = 151;
public override uint MessageId
{
    get { return Id; }
}

public bool hasStartupActions;
        public Types.CharacterBaseInformations[] characters;
        

public CharactersListMessage()
{
}

public CharactersListMessage(bool hasStartupActions, Types.CharacterBaseInformations[] characters)
        {
            this.hasStartupActions = hasStartupActions;
            this.characters = characters;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(hasStartupActions);
            writer.WriteUShort((ushort)characters.Length);
            foreach (var entry in characters)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

hasStartupActions = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            characters = new Types.CharacterBaseInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 characters[i] = Types.ProtocolTypeManager.GetInstance<Types.CharacterBaseInformations>(reader.ReadShort());
                 characters[i].Deserialize(reader);
            }
            

}


}


}