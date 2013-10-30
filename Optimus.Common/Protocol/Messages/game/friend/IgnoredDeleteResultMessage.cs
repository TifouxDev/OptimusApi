


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class IgnoredDeleteResultMessage : NetworkMessage
{

public const uint Id = 5677;
public override uint MessageId
{
    get { return Id; }
}

public bool success;
        public bool session;
        public string name;
        

public IgnoredDeleteResultMessage()
{
}

public IgnoredDeleteResultMessage(bool success, bool session, string name)
        {
            this.success = success;
            this.session = session;
            this.name = name;
        }
        

public override void Serialize(BigEndianWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, success);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, session);
            writer.WriteByte(flag1);
            writer.WriteUTF(name);
            

}

public override void Deserialize(BigEndianReader reader)
{

byte flag1 = reader.ReadByte();
            success = BooleanByteWrapper.GetFlag(flag1, 0);
            session = BooleanByteWrapper.GetFlag(flag1, 1);
            name = reader.ReadUTF();
            

}


}


}