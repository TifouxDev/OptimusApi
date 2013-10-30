


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MimicryObjectErrorMessage : ObjectErrorMessage
{

public const uint Id = 6461;
public override uint MessageId
{
    get { return Id; }
}

public bool preview;
        public sbyte errorCode;
        

public MimicryObjectErrorMessage()
{
}

public MimicryObjectErrorMessage(sbyte reason, bool preview, sbyte errorCode)
         : base(reason)
        {
            this.preview = preview;
            this.errorCode = errorCode;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(preview);
            writer.WriteSByte(errorCode);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            preview = reader.ReadBoolean();
            errorCode = reader.ReadSByte();
            

}


}


}