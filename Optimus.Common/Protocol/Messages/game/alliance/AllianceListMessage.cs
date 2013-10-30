


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceListMessage : NetworkMessage
{

public const uint Id = 6408;
public override uint MessageId
{
    get { return Id; }
}

public Types.AllianceFactSheetInformations[] alliances;
        

public AllianceListMessage()
{
}

public AllianceListMessage(Types.AllianceFactSheetInformations[] alliances)
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
            alliances = new Types.AllianceFactSheetInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliances[i] = new Types.AllianceFactSheetInformations();
                 alliances[i].Deserialize(reader);
            }
            

}


}


}