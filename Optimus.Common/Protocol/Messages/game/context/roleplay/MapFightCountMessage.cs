


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MapFightCountMessage : NetworkMessage
{

public const uint Id = 210;
public override uint MessageId
{
    get { return Id; }
}

public short fightCount;
        

public MapFightCountMessage()
{
}

public MapFightCountMessage(short fightCount)
        {
            this.fightCount = fightCount;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(fightCount);
            

}

public override void Deserialize(BigEndianReader reader)
{

fightCount = reader.ReadShort();
            if (fightCount < 0)
                throw new Exception("Forbidden value on fightCount = " + fightCount + ", it doesn't respect the following condition : fightCount < 0");
            

}


}


}