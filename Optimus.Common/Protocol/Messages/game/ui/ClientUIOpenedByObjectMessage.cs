


















// Generated on 10/27/2013 07:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ClientUIOpenedByObjectMessage : ClientUIOpenedMessage
{

public const uint Id = 6463;
public override uint MessageId
{
    get { return Id; }
}

public int uid;
        

public ClientUIOpenedByObjectMessage()
{
}

public ClientUIOpenedByObjectMessage(sbyte type, int uid)
         : base(type)
        {
            this.uid = uid;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(uid);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            uid = reader.ReadInt();
            if (uid < 0)
                throw new Exception("Forbidden value on uid = " + uid + ", it doesn't respect the following condition : uid < 0");
            

}


}


}