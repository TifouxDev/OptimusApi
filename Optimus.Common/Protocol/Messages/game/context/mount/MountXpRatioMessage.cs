


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MountXpRatioMessage : NetworkMessage
{

public const uint Id = 5970;
public override uint MessageId
{
    get { return Id; }
}

public sbyte ratio;
        

public MountXpRatioMessage()
{
}

public MountXpRatioMessage(sbyte ratio)
        {
            this.ratio = ratio;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(ratio);
            

}

public override void Deserialize(BigEndianReader reader)
{

ratio = reader.ReadSByte();
            if (ratio < 0)
                throw new Exception("Forbidden value on ratio = " + ratio + ", it doesn't respect the following condition : ratio < 0");
            

}


}


}