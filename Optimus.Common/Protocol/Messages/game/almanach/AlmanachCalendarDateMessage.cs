


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AlmanachCalendarDateMessage : NetworkMessage
{

public const uint Id = 6341;
public override uint MessageId
{
    get { return Id; }
}

public int date;
        

public AlmanachCalendarDateMessage()
{
}

public AlmanachCalendarDateMessage(int date)
        {
            this.date = date;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(date);
            

}

public override void Deserialize(BigEndianReader reader)
{

date = reader.ReadInt();
            

}


}


}