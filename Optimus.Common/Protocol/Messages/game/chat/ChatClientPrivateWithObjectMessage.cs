


















// Generated on 10/27/2013 07:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ChatClientPrivateWithObjectMessage : ChatClientPrivateMessage
{

public const uint Id = 852;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objects;
        

public ChatClientPrivateWithObjectMessage()
{
}

public ChatClientPrivateWithObjectMessage(string content, string receiver, Types.ObjectItem[] objects)
         : base(content, receiver)
        {
            this.objects = objects;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)objects.Length);
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            objects = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = new Types.ObjectItem();
                 objects[i].Deserialize(reader);
            }
            

}


}


}