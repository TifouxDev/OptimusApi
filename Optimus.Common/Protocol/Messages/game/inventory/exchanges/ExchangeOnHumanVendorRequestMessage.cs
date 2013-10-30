


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeOnHumanVendorRequestMessage : NetworkMessage
{

public const uint Id = 5772;
public override uint MessageId
{
    get { return Id; }
}

public int humanVendorId;
        public int humanVendorCell;
        

public ExchangeOnHumanVendorRequestMessage()
{
}

public ExchangeOnHumanVendorRequestMessage(int humanVendorId, int humanVendorCell)
        {
            this.humanVendorId = humanVendorId;
            this.humanVendorCell = humanVendorCell;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(humanVendorId);
            writer.WriteInt(humanVendorCell);
            

}

public override void Deserialize(BigEndianReader reader)
{

humanVendorId = reader.ReadInt();
            if (humanVendorId < 0)
                throw new Exception("Forbidden value on humanVendorId = " + humanVendorId + ", it doesn't respect the following condition : humanVendorId < 0");
            humanVendorCell = reader.ReadInt();
            if (humanVendorCell < 0)
                throw new Exception("Forbidden value on humanVendorCell = " + humanVendorCell + ", it doesn't respect the following condition : humanVendorCell < 0");
            

}


}


}