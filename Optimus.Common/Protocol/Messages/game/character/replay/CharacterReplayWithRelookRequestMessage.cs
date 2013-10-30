


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharacterReplayWithRelookRequestMessage : CharacterReplayRequestMessage
{

public const uint Id = 6354;
public override uint MessageId
{
    get { return Id; }
}

public int cosmeticId;
        

public CharacterReplayWithRelookRequestMessage()
{
}

public CharacterReplayWithRelookRequestMessage(int characterId, int cosmeticId)
         : base(characterId)
        {
            this.cosmeticId = cosmeticId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(cosmeticId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            cosmeticId = reader.ReadInt();
            if (cosmeticId < 0)
                throw new Exception("Forbidden value on cosmeticId = " + cosmeticId + ", it doesn't respect the following condition : cosmeticId < 0");
            

}


}


}