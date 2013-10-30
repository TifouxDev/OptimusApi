


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightStartingMessage : NetworkMessage
{

public const uint Id = 700;
public override uint MessageId
{
    get { return Id; }
}

public sbyte fightType;
        

public GameFightStartingMessage()
{
}

public GameFightStartingMessage(sbyte fightType)
        {
            this.fightType = fightType;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(fightType);
            

}

public override void Deserialize(BigEndianReader reader)
{

fightType = reader.ReadSByte();
            if (fightType < 0)
                throw new Exception("Forbidden value on fightType = " + fightType + ", it doesn't respect the following condition : fightType < 0");
            

}


}


}