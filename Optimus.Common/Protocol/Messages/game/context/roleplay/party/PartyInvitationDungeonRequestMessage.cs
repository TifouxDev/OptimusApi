


















// Generated on 10/27/2013 07:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyInvitationDungeonRequestMessage : PartyInvitationRequestMessage
{

public const uint Id = 6245;
public override uint MessageId
{
    get { return Id; }
}

public short dungeonId;
        

public PartyInvitationDungeonRequestMessage()
{
}

public PartyInvitationDungeonRequestMessage(string name, short dungeonId)
         : base(name)
        {
            this.dungeonId = dungeonId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(dungeonId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            dungeonId = reader.ReadShort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            

}


}


}