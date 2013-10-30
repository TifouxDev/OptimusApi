


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharacterDeletionRequestMessage : NetworkMessage
{

public const uint Id = 165;
public override uint MessageId
{
    get { return Id; }
}

public int characterId;
        public string secretAnswerHash;
        

public CharacterDeletionRequestMessage()
{
}

public CharacterDeletionRequestMessage(int characterId, string secretAnswerHash)
        {
            this.characterId = characterId;
            this.secretAnswerHash = secretAnswerHash;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(characterId);
            writer.WriteUTF(secretAnswerHash);
            

}

public override void Deserialize(BigEndianReader reader)
{

characterId = reader.ReadInt();
            if (characterId < 0)
                throw new Exception("Forbidden value on characterId = " + characterId + ", it doesn't respect the following condition : characterId < 0");
            secretAnswerHash = reader.ReadUTF();
            

}


}


}