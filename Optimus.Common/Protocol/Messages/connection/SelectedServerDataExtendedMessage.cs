


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class SelectedServerDataExtendedMessage : SelectedServerDataMessage
{

public const uint Id = 6469;
public override uint MessageId
{
    get { return Id; }
}

public short[] serverIds;
        

public SelectedServerDataExtendedMessage()
{
}

public SelectedServerDataExtendedMessage(short serverId, string address, ushort port, bool canCreateNewCharacter, string ticket, short[] serverIds)
         : base(serverId, address, port, canCreateNewCharacter, ticket)
        {
            this.serverIds = serverIds;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)serverIds.Length);
            foreach (var entry in serverIds)
            {
                 writer.WriteShort(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            serverIds = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 serverIds[i] = reader.ReadShort();
            }
            

}


}


}