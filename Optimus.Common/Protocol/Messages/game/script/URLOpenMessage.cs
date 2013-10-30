


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class URLOpenMessage : NetworkMessage
{

public const uint Id = 6266;
public override uint MessageId
{
    get { return Id; }
}

public int urlId;
        

public URLOpenMessage()
{
}

public URLOpenMessage(int urlId)
        {
            this.urlId = urlId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(urlId);
            

}

public override void Deserialize(BigEndianReader reader)
{

urlId = reader.ReadInt();
            if (urlId < 0)
                throw new Exception("Forbidden value on urlId = " + urlId + ", it doesn't respect the following condition : urlId < 0");
            

}


}


}