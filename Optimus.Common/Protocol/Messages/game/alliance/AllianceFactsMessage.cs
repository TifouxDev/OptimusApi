


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceFactsMessage : NetworkMessage
{

public const uint Id = 6414;
public override uint MessageId
{
    get { return Id; }
}

public Types.AllianceFactSheetInformations infos;
        public Types.GuildInAllianceInformations[] guilds;
        public short[] controlledSubareaIds;
        

public AllianceFactsMessage()
{
}

public AllianceFactsMessage(Types.AllianceFactSheetInformations infos, Types.GuildInAllianceInformations[] guilds, short[] controlledSubareaIds)
        {
            this.infos = infos;
            this.guilds = guilds;
            this.controlledSubareaIds = controlledSubareaIds;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
            writer.WriteUShort((ushort)guilds.Length);
            foreach (var entry in guilds)
            {
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)controlledSubareaIds.Length);
            foreach (var entry in controlledSubareaIds)
            {
                 writer.WriteShort(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

infos = Types.ProtocolTypeManager.GetInstance<Types.AllianceFactSheetInformations>(reader.ReadShort());
            infos.Deserialize(reader);
            var limit = reader.ReadUShort();
            guilds = new Types.GuildInAllianceInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guilds[i] = new Types.GuildInAllianceInformations();
                 guilds[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            controlledSubareaIds = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 controlledSubareaIds[i] = reader.ReadShort();
            }
            

}


}


}