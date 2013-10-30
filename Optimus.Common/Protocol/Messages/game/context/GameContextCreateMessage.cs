


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameContextCreateMessage : NetworkMessage
{

public const uint Id = 200;
public override uint MessageId
{
    get { return Id; }
}

public sbyte context;
        

public GameContextCreateMessage()
{
}

public GameContextCreateMessage(sbyte context)
        {
            this.context = context;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(context);
            

}

public override void Deserialize(BigEndianReader reader)
{

context = reader.ReadSByte();
            if (context < 0)
                throw new Exception("Forbidden value on context = " + context + ", it doesn't respect the following condition : context < 0");
            

}


}


}