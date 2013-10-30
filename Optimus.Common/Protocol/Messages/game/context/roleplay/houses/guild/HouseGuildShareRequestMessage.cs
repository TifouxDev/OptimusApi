


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class HouseGuildShareRequestMessage : NetworkMessage
{

public const uint Id = 5704;
public override uint MessageId
{
    get { return Id; }
}

public bool enable;
        public uint rights;
        

public HouseGuildShareRequestMessage()
{
}

public HouseGuildShareRequestMessage(bool enable, uint rights)
        {
            this.enable = enable;
            this.rights = rights;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(enable);
            writer.WriteUInt(rights);
            

}

public override void Deserialize(BigEndianReader reader)
{

enable = reader.ReadBoolean();
            rights = reader.ReadUInt();
            if (rights < 0 || rights > 4.294967295E9)
                throw new Exception("Forbidden value on rights = " + rights + ", it doesn't respect the following condition : rights < 0 || rights > 4.294967295E9");
            

}


}


}