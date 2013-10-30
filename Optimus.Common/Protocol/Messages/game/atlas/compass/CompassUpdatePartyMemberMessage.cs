


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CompassUpdatePartyMemberMessage : CompassUpdateMessage
{

public const uint Id = 5589;
public override uint MessageId
{
    get { return Id; }
}

public int memberId;
        

public CompassUpdatePartyMemberMessage()
{
}

public CompassUpdatePartyMemberMessage(sbyte type, short worldX, short worldY, int memberId)
         : base(type, worldX, worldY)
        {
            this.memberId = memberId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(memberId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            memberId = reader.ReadInt();
            if (memberId < 0)
                throw new Exception("Forbidden value on memberId = " + memberId + ", it doesn't respect the following condition : memberId < 0");
            

}


}


}