


















// Generated on 10/27/2013 07:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ClientKeyMessage : NetworkMessage
{

public const uint Id = 5607;
public override uint MessageId
{
    get { return Id; }
}

public string key;
        

public ClientKeyMessage()
{
}

public ClientKeyMessage(string key)
        {
            this.key = key;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(key);
            

}

public override void Deserialize(BigEndianReader reader)
{

key = reader.ReadUTF();
            

}


}


}