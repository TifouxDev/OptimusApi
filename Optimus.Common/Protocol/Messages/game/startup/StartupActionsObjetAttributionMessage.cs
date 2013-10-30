


















// Generated on 10/27/2013 07:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class StartupActionsObjetAttributionMessage : NetworkMessage
{

public const uint Id = 1303;
public override uint MessageId
{
    get { return Id; }
}

public int actionId;
        public int characterId;
        

public StartupActionsObjetAttributionMessage()
{
}

public StartupActionsObjetAttributionMessage(int actionId, int characterId)
        {
            this.actionId = actionId;
            this.characterId = characterId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(actionId);
            writer.WriteInt(characterId);
            

}

public override void Deserialize(BigEndianReader reader)
{

actionId = reader.ReadInt();
            if (actionId < 0)
                throw new Exception("Forbidden value on actionId = " + actionId + ", it doesn't respect the following condition : actionId < 0");
            characterId = reader.ReadInt();
            if (characterId < 0)
                throw new Exception("Forbidden value on characterId = " + characterId + ", it doesn't respect the following condition : characterId < 0");
            

}


}


}