


















// Generated on 10/27/2013 07:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightCastOnTargetRequestMessage : NetworkMessage
{

public const uint Id = 6330;
public override uint MessageId
{
    get { return Id; }
}

public short spellId;
        public int targetId;
        

public GameActionFightCastOnTargetRequestMessage()
{
}

public GameActionFightCastOnTargetRequestMessage(short spellId, int targetId)
        {
            this.spellId = spellId;
            this.targetId = targetId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(spellId);
            writer.WriteInt(targetId);
            

}

public override void Deserialize(BigEndianReader reader)
{

spellId = reader.ReadShort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            targetId = reader.ReadInt();
            

}


}


}