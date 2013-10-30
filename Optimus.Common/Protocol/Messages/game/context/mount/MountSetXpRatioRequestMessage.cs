


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MountSetXpRatioRequestMessage : NetworkMessage
{

public const uint Id = 5989;
public override uint MessageId
{
    get { return Id; }
}

public sbyte xpRatio;
        

public MountSetXpRatioRequestMessage()
{
}

public MountSetXpRatioRequestMessage(sbyte xpRatio)
        {
            this.xpRatio = xpRatio;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(xpRatio);
            

}

public override void Deserialize(BigEndianReader reader)
{

xpRatio = reader.ReadSByte();
            if (xpRatio < 0)
                throw new Exception("Forbidden value on xpRatio = " + xpRatio + ", it doesn't respect the following condition : xpRatio < 0");
            

}


}


}