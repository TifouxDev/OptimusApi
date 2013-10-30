


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MapRunningFightListMessage : NetworkMessage
{

public const uint Id = 5743;
public override uint MessageId
{
    get { return Id; }
}

public Types.FightExternalInformations[] fights;
        

public MapRunningFightListMessage()
{
}

public MapRunningFightListMessage(Types.FightExternalInformations[] fights)
        {
            this.fights = fights;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)fights.Length);
            foreach (var entry in fights)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            fights = new Types.FightExternalInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 fights[i] = new Types.FightExternalInformations();
                 fights[i].Deserialize(reader);
            }
            

}


}


}