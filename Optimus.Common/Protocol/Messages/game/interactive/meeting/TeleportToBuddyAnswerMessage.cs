


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TeleportToBuddyAnswerMessage : NetworkMessage
{

public const uint Id = 6293;
public override uint MessageId
{
    get { return Id; }
}

public short dungeonId;
        public int buddyId;
        public bool accept;
        

public TeleportToBuddyAnswerMessage()
{
}

public TeleportToBuddyAnswerMessage(short dungeonId, int buddyId, bool accept)
        {
            this.dungeonId = dungeonId;
            this.buddyId = buddyId;
            this.accept = accept;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(dungeonId);
            writer.WriteInt(buddyId);
            writer.WriteBoolean(accept);
            

}

public override void Deserialize(BigEndianReader reader)
{

dungeonId = reader.ReadShort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            buddyId = reader.ReadInt();
            if (buddyId < 0)
                throw new Exception("Forbidden value on buddyId = " + buddyId + ", it doesn't respect the following condition : buddyId < 0");
            accept = reader.ReadBoolean();
            

}


}


}