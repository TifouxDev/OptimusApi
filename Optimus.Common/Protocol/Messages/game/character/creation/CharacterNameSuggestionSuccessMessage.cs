


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharacterNameSuggestionSuccessMessage : NetworkMessage
{

public const uint Id = 5544;
public override uint MessageId
{
    get { return Id; }
}

public string suggestion;
        

public CharacterNameSuggestionSuccessMessage()
{
}

public CharacterNameSuggestionSuccessMessage(string suggestion)
        {
            this.suggestion = suggestion;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(suggestion);
            

}

public override void Deserialize(BigEndianReader reader)
{

suggestion = reader.ReadUTF();
            

}


}


}