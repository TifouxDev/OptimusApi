


















// Generated on 10/27/2013 07:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class KrosmasterTransferMessage : NetworkMessage
{

public const uint Id = 6348;
public override uint MessageId
{
    get { return Id; }
}

public string uid;
        public sbyte failure;
        

public KrosmasterTransferMessage()
{
}

public KrosmasterTransferMessage(string uid, sbyte failure)
        {
            this.uid = uid;
            this.failure = failure;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(uid);
            writer.WriteSByte(failure);
            

}

public override void Deserialize(BigEndianReader reader)
{

uid = reader.ReadUTF();
            failure = reader.ReadSByte();
            if (failure < 0)
                throw new Exception("Forbidden value on failure = " + failure + ", it doesn't respect the following condition : failure < 0");
            

}


}


}