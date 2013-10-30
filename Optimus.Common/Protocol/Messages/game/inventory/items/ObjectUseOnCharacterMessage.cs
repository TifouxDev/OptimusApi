


















// Generated on 10/27/2013 07:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ObjectUseOnCharacterMessage : ObjectUseMessage
{

public const uint Id = 3003;
public override uint MessageId
{
    get { return Id; }
}

public int characterId;
        

public ObjectUseOnCharacterMessage()
{
}

public ObjectUseOnCharacterMessage(int objectUID, int characterId)
         : base(objectUID)
        {
            this.characterId = characterId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(characterId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            characterId = reader.ReadInt();
            if (characterId < 0)
                throw new Exception("Forbidden value on characterId = " + characterId + ", it doesn't respect the following condition : characterId < 0");
            

}


}


}