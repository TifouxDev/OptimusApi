


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class NumericWhoIsMessage : NetworkMessage
{

public const uint Id = 6297;
public override uint MessageId
{
    get { return Id; }
}

public int playerId;
        public int accountId;
        

public NumericWhoIsMessage()
{
}

public NumericWhoIsMessage(int playerId, int accountId)
        {
            this.playerId = playerId;
            this.accountId = accountId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(playerId);
            writer.WriteInt(accountId);
            

}

public override void Deserialize(BigEndianReader reader)
{

playerId = reader.ReadInt();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            

}


}


}