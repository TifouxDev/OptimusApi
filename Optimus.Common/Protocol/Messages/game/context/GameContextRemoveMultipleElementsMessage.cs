


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameContextRemoveMultipleElementsMessage : NetworkMessage
{

public const uint Id = 252;
public override uint MessageId
{
    get { return Id; }
}

public int[] id;
        

public GameContextRemoveMultipleElementsMessage()
{
}

public GameContextRemoveMultipleElementsMessage(int[] id)
        {
            this.id = id;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)id.Length);
            foreach (var entry in id)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            id = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 id[i] = reader.ReadInt();
            }
            

}


}


}