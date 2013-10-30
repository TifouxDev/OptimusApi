


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameContextRemoveElementWithEventMessage : GameContextRemoveElementMessage
{

public const uint Id = 6412;
public override uint MessageId
{
    get { return Id; }
}

public sbyte elementEventId;
        

public GameContextRemoveElementWithEventMessage()
{
}

public GameContextRemoveElementWithEventMessage(int id, sbyte elementEventId)
         : base(id)
        {
            this.elementEventId = elementEventId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(elementEventId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            elementEventId = reader.ReadSByte();
            if (elementEventId < 0)
                throw new Exception("Forbidden value on elementEventId = " + elementEventId + ", it doesn't respect the following condition : elementEventId < 0");
            

}


}


}