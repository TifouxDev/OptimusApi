


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class DocumentReadingBeginMessage : NetworkMessage
{

public const uint Id = 5675;
public override uint MessageId
{
    get { return Id; }
}

public short documentId;
        

public DocumentReadingBeginMessage()
{
}

public DocumentReadingBeginMessage(short documentId)
        {
            this.documentId = documentId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(documentId);
            

}

public override void Deserialize(BigEndianReader reader)
{

documentId = reader.ReadShort();
            if (documentId < 0)
                throw new Exception("Forbidden value on documentId = " + documentId + ", it doesn't respect the following condition : documentId < 0");
            

}


}


}