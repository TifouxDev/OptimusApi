


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class BasicDateMessage : NetworkMessage
{

public const uint Id = 177;
public override uint MessageId
{
    get { return Id; }
}

public sbyte day;
        public sbyte month;
        public short year;
        

public BasicDateMessage()
{
}

public BasicDateMessage(sbyte day, sbyte month, short year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(day);
            writer.WriteSByte(month);
            writer.WriteShort(year);
            

}

public override void Deserialize(BigEndianReader reader)
{

day = reader.ReadSByte();
            if (day < 0)
                throw new Exception("Forbidden value on day = " + day + ", it doesn't respect the following condition : day < 0");
            month = reader.ReadSByte();
            if (month < 0)
                throw new Exception("Forbidden value on month = " + month + ", it doesn't respect the following condition : month < 0");
            year = reader.ReadShort();
            if (year < 0)
                throw new Exception("Forbidden value on year = " + year + ", it doesn't respect the following condition : year < 0");
            

}


}


}