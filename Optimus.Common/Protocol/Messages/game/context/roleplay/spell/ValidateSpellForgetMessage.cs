


















// Generated on 10/27/2013 07:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ValidateSpellForgetMessage : NetworkMessage
{

public const uint Id = 1700;
public override uint MessageId
{
    get { return Id; }
}

public short spellId;
        

public ValidateSpellForgetMessage()
{
}

public ValidateSpellForgetMessage(short spellId)
        {
            this.spellId = spellId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(spellId);
            

}

public override void Deserialize(BigEndianReader reader)
{

spellId = reader.ReadShort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            

}


}


}