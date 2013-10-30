


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class EmoteListMessage : NetworkMessage
{

public const uint Id = 5689;
public override uint MessageId
{
    get { return Id; }
}

public sbyte[] emoteIds;
        

public EmoteListMessage()
{
}

public EmoteListMessage(sbyte[] emoteIds)
        {
            this.emoteIds = emoteIds;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)emoteIds.Length);
            foreach (var entry in emoteIds)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            emoteIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 emoteIds[i] = reader.ReadSByte();
            }
            

}


}


}