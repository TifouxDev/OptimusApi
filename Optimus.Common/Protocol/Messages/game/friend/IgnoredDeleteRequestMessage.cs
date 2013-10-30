


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class IgnoredDeleteRequestMessage : NetworkMessage
{

public const uint Id = 5680;
public override uint MessageId
{
    get { return Id; }
}

public int accountId;
        public bool session;
        

public IgnoredDeleteRequestMessage()
{
}

public IgnoredDeleteRequestMessage(int accountId, bool session)
        {
            this.accountId = accountId;
            this.session = session;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteBoolean(session);
            

}

public override void Deserialize(BigEndianReader reader)
{

accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            session = reader.ReadBoolean();
            

}


}


}