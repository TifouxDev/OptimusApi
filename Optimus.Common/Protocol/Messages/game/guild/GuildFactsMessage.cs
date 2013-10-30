


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildFactsMessage : NetworkMessage
{

public const uint Id = 6415;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildFactSheetInformations infos;
        public int creationDate;
        public short nbTaxCollectors;
        public bool enabled;
        public Types.CharacterMinimalInformations[] members;
        

public GuildFactsMessage()
{
}

public GuildFactsMessage(Types.GuildFactSheetInformations infos, int creationDate, short nbTaxCollectors, bool enabled, Types.CharacterMinimalInformations[] members)
        {
            this.infos = infos;
            this.creationDate = creationDate;
            this.nbTaxCollectors = nbTaxCollectors;
            this.enabled = enabled;
            this.members = members;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
            writer.WriteInt(creationDate);
            writer.WriteShort(nbTaxCollectors);
            writer.WriteBoolean(enabled);
            writer.WriteUShort((ushort)members.Length);
            foreach (var entry in members)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

infos = Types.ProtocolTypeManager.GetInstance<Types.GuildFactSheetInformations>(reader.ReadShort());
            infos.Deserialize(reader);
            creationDate = reader.ReadInt();
            if (creationDate < 0)
                throw new Exception("Forbidden value on creationDate = " + creationDate + ", it doesn't respect the following condition : creationDate < 0");
            nbTaxCollectors = reader.ReadShort();
            if (nbTaxCollectors < 0)
                throw new Exception("Forbidden value on nbTaxCollectors = " + nbTaxCollectors + ", it doesn't respect the following condition : nbTaxCollectors < 0");
            enabled = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            members = new Types.CharacterMinimalInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 members[i] = new Types.CharacterMinimalInformations();
                 members[i].Deserialize(reader);
            }
            

}


}


}