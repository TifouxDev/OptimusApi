


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceVersatileInfoListMessage : NetworkMessage
{

public const uint Id = 6436;
public override uint MessageId
{
    get { return Id; }
}

public Types.AllianceVersatileInformations[] alliances;
        

public AllianceVersatileInfoListMessage()
{
}

public AllianceVersatileInfoListMessage(Types.AllianceVersatileInformations[] alliances)
        {
            this.alliances = alliances;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)alliances.Length);
            foreach (var entry in alliances)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            alliances = new Types.AllianceVersatileInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliances[i] = new Types.AllianceVersatileInformations();
                 alliances[i].Deserialize(reader);
            }
            

}


}


}