


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeCraftResultMagicWithObjectDescMessage : ExchangeCraftResultWithObjectDescMessage
{

public const uint Id = 6188;
public override uint MessageId
{
    get { return Id; }
}

public sbyte magicPoolStatus;
        

public ExchangeCraftResultMagicWithObjectDescMessage()
{
}

public ExchangeCraftResultMagicWithObjectDescMessage(sbyte craftResult, Types.ObjectItemNotInContainer objectInfo, sbyte magicPoolStatus)
         : base(craftResult, objectInfo)
        {
            this.magicPoolStatus = magicPoolStatus;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(magicPoolStatus);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            magicPoolStatus = reader.ReadSByte();
            

}


}


}