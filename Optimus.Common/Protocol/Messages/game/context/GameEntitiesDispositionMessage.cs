


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameEntitiesDispositionMessage : NetworkMessage
{

public const uint Id = 5696;
public override uint MessageId
{
    get { return Id; }
}

public Types.IdentifiedEntityDispositionInformations[] dispositions;
        

public GameEntitiesDispositionMessage()
{
}

public GameEntitiesDispositionMessage(Types.IdentifiedEntityDispositionInformations[] dispositions)
        {
            this.dispositions = dispositions;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)dispositions.Length);
            foreach (var entry in dispositions)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            dispositions = new Types.IdentifiedEntityDispositionInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 dispositions[i] = new Types.IdentifiedEntityDispositionInformations();
                 dispositions[i].Deserialize(reader);
            }
            

}


}


}