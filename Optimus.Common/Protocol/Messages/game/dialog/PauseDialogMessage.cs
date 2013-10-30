


















// Generated on 10/27/2013 07:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PauseDialogMessage : NetworkMessage
{

public const uint Id = 6012;
public override uint MessageId
{
    get { return Id; }
}

public sbyte dialogType;
        

public PauseDialogMessage()
{
}

public PauseDialogMessage(sbyte dialogType)
        {
            this.dialogType = dialogType;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(dialogType);
            

}

public override void Deserialize(BigEndianReader reader)
{

dialogType = reader.ReadSByte();
            if (dialogType < 0)
                throw new Exception("Forbidden value on dialogType = " + dialogType + ", it doesn't respect the following condition : dialogType < 0");
            

}


}


}