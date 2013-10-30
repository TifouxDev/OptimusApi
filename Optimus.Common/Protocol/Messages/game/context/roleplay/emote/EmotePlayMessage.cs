


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class EmotePlayMessage : EmotePlayAbstractMessage
{

public const uint Id = 5683;
public override uint MessageId
{
    get { return Id; }
}

public int actorId;
        public int accountId;
        

public EmotePlayMessage()
{
}

public EmotePlayMessage(sbyte emoteId, double emoteStartTime, int actorId, int accountId)
         : base(emoteId, emoteStartTime)
        {
            this.actorId = actorId;
            this.accountId = accountId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(actorId);
            writer.WriteInt(accountId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            actorId = reader.ReadInt();
            accountId = reader.ReadInt();
            

}


}


}