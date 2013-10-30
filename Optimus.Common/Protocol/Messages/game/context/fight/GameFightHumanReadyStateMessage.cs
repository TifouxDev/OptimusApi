


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightHumanReadyStateMessage : NetworkMessage
{

public const uint Id = 740;
public override uint MessageId
{
    get { return Id; }
}

public int characterId;
        public bool isReady;
        

public GameFightHumanReadyStateMessage()
{
}

public GameFightHumanReadyStateMessage(int characterId, bool isReady)
        {
            this.characterId = characterId;
            this.isReady = isReady;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(characterId);
            writer.WriteBoolean(isReady);
            

}

public override void Deserialize(BigEndianReader reader)
{

characterId = reader.ReadInt();
            if (characterId < 0)
                throw new Exception("Forbidden value on characterId = " + characterId + ", it doesn't respect the following condition : characterId < 0");
            isReady = reader.ReadBoolean();
            

}


}


}