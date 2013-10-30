


















// Generated on 10/27/2013 07:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PrismsListRegisterMessage : NetworkMessage
{

public const uint Id = 6441;
public override uint MessageId
{
    get { return Id; }
}

public sbyte listen;
        

public PrismsListRegisterMessage()
{
}

public PrismsListRegisterMessage(sbyte listen)
        {
            this.listen = listen;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(listen);
            

}

public override void Deserialize(BigEndianReader reader)
{

listen = reader.ReadSByte();
            if (listen < 0)
                throw new Exception("Forbidden value on listen = " + listen + ", it doesn't respect the following condition : listen < 0");
            

}


}


}