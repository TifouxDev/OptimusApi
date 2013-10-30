


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AbstractPartyMessage : NetworkMessage
{

public const uint Id = 6274;
public override uint MessageId
{
    get { return Id; }
}

public int partyId;
        

public AbstractPartyMessage()
{
}

public AbstractPartyMessage(int partyId)
        {
            this.partyId = partyId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(partyId);
            

}

public override void Deserialize(BigEndianReader reader)
{

partyId = reader.ReadInt();
            if (partyId < 0)
                throw new Exception("Forbidden value on partyId = " + partyId + ", it doesn't respect the following condition : partyId < 0");
            

}


}


}