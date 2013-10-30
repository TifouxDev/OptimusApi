


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PrismFightStateUpdateMessage : NetworkMessage
{

public const uint Id = 6040;
public override uint MessageId
{
    get { return Id; }
}

public sbyte state;
        

public PrismFightStateUpdateMessage()
{
}

public PrismFightStateUpdateMessage(sbyte state)
        {
            this.state = state;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(state);
            

}

public override void Deserialize(BigEndianReader reader)
{

state = reader.ReadSByte();
            if (state < 0)
                throw new Exception("Forbidden value on state = " + state + ", it doesn't respect the following condition : state < 0");
            

}


}


}