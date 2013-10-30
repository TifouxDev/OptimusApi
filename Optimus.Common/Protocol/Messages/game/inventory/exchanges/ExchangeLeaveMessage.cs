


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeLeaveMessage : LeaveDialogMessage
{

public const uint Id = 5628;
public override uint MessageId
{
    get { return Id; }
}

public bool success;
        

public ExchangeLeaveMessage()
{
}

public ExchangeLeaveMessage(sbyte dialogType, bool success)
         : base(dialogType)
        {
            this.success = success;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(success);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            success = reader.ReadBoolean();
            

}


}


}