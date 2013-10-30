


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightNoSpellCastMessage : NetworkMessage
{

public const uint Id = 6132;
public override uint MessageId
{
    get { return Id; }
}

public int spellLevelId;
        

public GameActionFightNoSpellCastMessage()
{
}

public GameActionFightNoSpellCastMessage(int spellLevelId)
        {
            this.spellLevelId = spellLevelId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(spellLevelId);
            

}

public override void Deserialize(BigEndianReader reader)
{

spellLevelId = reader.ReadInt();
            if (spellLevelId < 0)
                throw new Exception("Forbidden value on spellLevelId = " + spellLevelId + ", it doesn't respect the following condition : spellLevelId < 0");
            

}


}


}