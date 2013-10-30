


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class IdentificationFailedBannedMessage : IdentificationFailedMessage
{

public const uint Id = 6174;
public override uint MessageId
{
    get { return Id; }
}

public double banEndDate;
        

public IdentificationFailedBannedMessage()
{
}

public IdentificationFailedBannedMessage(sbyte reason, double banEndDate)
         : base(reason)
        {
            this.banEndDate = banEndDate;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(banEndDate);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            banEndDate = reader.ReadDouble();
            if (banEndDate < 0)
                throw new Exception("Forbidden value on banEndDate = " + banEndDate + ", it doesn't respect the following condition : banEndDate < 0");
            

}


}


}