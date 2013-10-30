


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MountEquipedErrorMessage : NetworkMessage
{

public const uint Id = 5963;
public override uint MessageId
{
    get { return Id; }
}

public sbyte errorType;
        

public MountEquipedErrorMessage()
{
}

public MountEquipedErrorMessage(sbyte errorType)
        {
            this.errorType = errorType;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(errorType);
            

}

public override void Deserialize(BigEndianReader reader)
{

errorType = reader.ReadSByte();
            if (errorType < 0)
                throw new Exception("Forbidden value on errorType = " + errorType + ", it doesn't respect the following condition : errorType < 0");
            

}


}


}