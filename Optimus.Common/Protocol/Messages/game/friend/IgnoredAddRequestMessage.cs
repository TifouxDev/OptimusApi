


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class IgnoredAddRequestMessage : NetworkMessage
{

public const uint Id = 5673;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public bool session;
        

public IgnoredAddRequestMessage()
{
}

public IgnoredAddRequestMessage(string name, bool session)
        {
            this.name = name;
            this.session = session;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(name);
            writer.WriteBoolean(session);
            

}

public override void Deserialize(BigEndianReader reader)
{

name = reader.ReadUTF();
            session = reader.ReadBoolean();
            

}


}


}