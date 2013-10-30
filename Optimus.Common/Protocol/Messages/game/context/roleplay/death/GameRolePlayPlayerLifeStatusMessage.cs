


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameRolePlayPlayerLifeStatusMessage : NetworkMessage
{

public const uint Id = 5996;
public override uint MessageId
{
    get { return Id; }
}

public sbyte state;
        

public GameRolePlayPlayerLifeStatusMessage()
{
}

public GameRolePlayPlayerLifeStatusMessage(sbyte state)
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