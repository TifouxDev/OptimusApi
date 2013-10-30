


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class LockableUseCodeMessage : NetworkMessage
{

public const uint Id = 5667;
public override uint MessageId
{
    get { return Id; }
}

public string code;
        

public LockableUseCodeMessage()
{
}

public LockableUseCodeMessage(string code)
        {
            this.code = code;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(code);
            

}

public override void Deserialize(BigEndianReader reader)
{

code = reader.ReadUTF();
            

}


}


}