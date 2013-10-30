


















// Generated on 10/27/2013 07:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ObjectsAddedMessage : NetworkMessage
{

public const uint Id = 6033;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] @object;
        

public ObjectsAddedMessage()
{
}

public ObjectsAddedMessage(Types.ObjectItem[] @object)
        {
            this.@object = @object;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)@object.Length);
            foreach (var entry in @object)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            @object = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 @object[i] = new Types.ObjectItem();
                 @object[i].Deserialize(reader);
            }
            

}


}


}