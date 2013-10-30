


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharacterReportMessage : NetworkMessage
{

public const uint Id = 6079;
public override uint MessageId
{
    get { return Id; }
}

public uint reportedId;
        public sbyte reason;
        

public CharacterReportMessage()
{
}

public CharacterReportMessage(uint reportedId, sbyte reason)
        {
            this.reportedId = reportedId;
            this.reason = reason;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUInt(reportedId);
            writer.WriteSByte(reason);
            

}

public override void Deserialize(BigEndianReader reader)
{

reportedId = reader.ReadUInt();
            if (reportedId < 0 || reportedId > 4.294967295E9)
                throw new Exception("Forbidden value on reportedId = " + reportedId + ", it doesn't respect the following condition : reportedId < 0 || reportedId > 4.294967295E9");
            reason = reader.ReadSByte();
            if (reason < 0)
                throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
            

}


}


}