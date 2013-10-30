


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PrismInfoJoinLeaveRequestMessage : NetworkMessage
{

public const uint Id = 5844;
public override uint MessageId
{
    get { return Id; }
}

public bool join;
        

public PrismInfoJoinLeaveRequestMessage()
{
}

public PrismInfoJoinLeaveRequestMessage(bool join)
        {
            this.join = join;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(join);
            

}

public override void Deserialize(BigEndianReader reader)
{

join = reader.ReadBoolean();
            

}


}


}