


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class LockableShowCodeDialogMessage : NetworkMessage
{

public const uint Id = 5740;
public override uint MessageId
{
    get { return Id; }
}

public bool changeOrUse;
        public sbyte codeSize;
        

public LockableShowCodeDialogMessage()
{
}

public LockableShowCodeDialogMessage(bool changeOrUse, sbyte codeSize)
        {
            this.changeOrUse = changeOrUse;
            this.codeSize = codeSize;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(changeOrUse);
            writer.WriteSByte(codeSize);
            

}

public override void Deserialize(BigEndianReader reader)
{

changeOrUse = reader.ReadBoolean();
            codeSize = reader.ReadSByte();
            if (codeSize < 0)
                throw new Exception("Forbidden value on codeSize = " + codeSize + ", it doesn't respect the following condition : codeSize < 0");
            

}


}


}