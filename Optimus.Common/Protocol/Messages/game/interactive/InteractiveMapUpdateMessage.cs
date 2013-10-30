


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class InteractiveMapUpdateMessage : NetworkMessage
{

public const uint Id = 5002;
public override uint MessageId
{
    get { return Id; }
}

public Types.InteractiveElement[] interactiveElements;
        

public InteractiveMapUpdateMessage()
{
}

public InteractiveMapUpdateMessage(Types.InteractiveElement[] interactiveElements)
        {
            this.interactiveElements = interactiveElements;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)interactiveElements.Length);
            foreach (var entry in interactiveElements)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            interactiveElements = new Types.InteractiveElement[limit];
            for (int i = 0; i < limit; i++)
            {
                 interactiveElements[i] = Types.ProtocolTypeManager.GetInstance<Types.InteractiveElement>(reader.ReadShort());
                 interactiveElements[i].Deserialize(reader);
            }
            

}


}


}