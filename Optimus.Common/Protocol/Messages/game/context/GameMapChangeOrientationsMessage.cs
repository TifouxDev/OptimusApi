


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameMapChangeOrientationsMessage : NetworkMessage
{

public const uint Id = 6155;
public override uint MessageId
{
    get { return Id; }
}

public Types.ActorOrientation[] orientations;
        

public GameMapChangeOrientationsMessage()
{
}

public GameMapChangeOrientationsMessage(Types.ActorOrientation[] orientations)
        {
            this.orientations = orientations;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)orientations.Length);
            foreach (var entry in orientations)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            orientations = new Types.ActorOrientation[limit];
            for (int i = 0; i < limit; i++)
            {
                 orientations[i] = new Types.ActorOrientation();
                 orientations[i].Deserialize(reader);
            }
            

}


}


}