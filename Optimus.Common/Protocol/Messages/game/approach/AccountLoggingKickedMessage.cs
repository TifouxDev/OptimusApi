


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AccountLoggingKickedMessage : NetworkMessage
{

public const uint Id = 6029;
public override uint MessageId
{
    get { return Id; }
}

public int days;
        public int hours;
        public int minutes;
        

public AccountLoggingKickedMessage()
{
}

public AccountLoggingKickedMessage(int days, int hours, int minutes)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(days);
            writer.WriteInt(hours);
            writer.WriteInt(minutes);
            

}

public override void Deserialize(BigEndianReader reader)
{

days = reader.ReadInt();
            if (days < 0)
                throw new Exception("Forbidden value on days = " + days + ", it doesn't respect the following condition : days < 0");
            hours = reader.ReadInt();
            if (hours < 0)
                throw new Exception("Forbidden value on hours = " + hours + ", it doesn't respect the following condition : hours < 0");
            minutes = reader.ReadInt();
            if (minutes < 0)
                throw new Exception("Forbidden value on minutes = " + minutes + ", it doesn't respect the following condition : minutes < 0");
            

}


}


}