


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameContextRemoveMultipleElementsWithEventsMessage : GameContextRemoveMultipleElementsMessage
{

public const uint Id = 6416;
public override uint MessageId
{
    get { return Id; }
}

public sbyte[] elementEventIds;
        

public GameContextRemoveMultipleElementsWithEventsMessage()
{
}

public GameContextRemoveMultipleElementsWithEventsMessage(int[] id, sbyte[] elementEventIds)
         : base(id)
        {
            this.elementEventIds = elementEventIds;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)elementEventIds.Length);
            foreach (var entry in elementEventIds)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            elementEventIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 elementEventIds[i] = reader.ReadSByte();
            }
            

}


}


}