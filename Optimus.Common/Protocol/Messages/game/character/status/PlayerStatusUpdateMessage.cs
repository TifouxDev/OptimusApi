


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PlayerStatusUpdateMessage : NetworkMessage
{

public const uint Id = 6386;
public override uint MessageId
{
    get { return Id; }
}

public int accountId;
        public int playerId;
        public Types.PlayerStatus status;
        

public PlayerStatusUpdateMessage()
{
}

public PlayerStatusUpdateMessage(int accountId, int playerId, Types.PlayerStatus status)
        {
            this.accountId = accountId;
            this.playerId = playerId;
            this.status = status;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteInt(playerId);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            playerId = reader.ReadInt();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            status = Types.ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadShort());
            status.Deserialize(reader);
            

}


}


}