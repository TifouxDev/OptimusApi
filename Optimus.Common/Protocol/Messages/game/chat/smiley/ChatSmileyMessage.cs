


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ChatSmileyMessage : NetworkMessage
{

public const uint Id = 801;
public override uint MessageId
{
    get { return Id; }
}

public int entityId;
        public sbyte smileyId;
        public int accountId;
        

public ChatSmileyMessage()
{
}

public ChatSmileyMessage(int entityId, sbyte smileyId, int accountId)
        {
            this.entityId = entityId;
            this.smileyId = smileyId;
            this.accountId = accountId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(entityId);
            writer.WriteSByte(smileyId);
            writer.WriteInt(accountId);
            

}

public override void Deserialize(BigEndianReader reader)
{

entityId = reader.ReadInt();
            smileyId = reader.ReadSByte();
            if (smileyId < 0)
                throw new Exception("Forbidden value on smileyId = " + smileyId + ", it doesn't respect the following condition : smileyId < 0");
            accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            

}


}


}