


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class StatedMapUpdateMessage : NetworkMessage
{

public const uint Id = 5716;
public override uint MessageId
{
    get { return Id; }
}

public Types.StatedElement[] statedElements;
        

public StatedMapUpdateMessage()
{
}

public StatedMapUpdateMessage(Types.StatedElement[] statedElements)
        {
            this.statedElements = statedElements;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)statedElements.Length);
            foreach (var entry in statedElements)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            statedElements = new Types.StatedElement[limit];
            for (int i = 0; i < limit; i++)
            {
                 statedElements[i] = new Types.StatedElement();
                 statedElements[i].Deserialize(reader);
            }
            

}


}


}