


















// Generated on 10/27/2013 07:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TitleLostMessage : NetworkMessage
{

public const uint Id = 6371;
public override uint MessageId
{
    get { return Id; }
}

public short titleId;
        

public TitleLostMessage()
{
}

public TitleLostMessage(short titleId)
        {
            this.titleId = titleId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(titleId);
            

}

public override void Deserialize(BigEndianReader reader)
{

titleId = reader.ReadShort();
            if (titleId < 0)
                throw new Exception("Forbidden value on titleId = " + titleId + ", it doesn't respect the following condition : titleId < 0");
            

}


}


}