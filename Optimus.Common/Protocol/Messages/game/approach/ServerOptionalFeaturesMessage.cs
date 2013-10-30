


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ServerOptionalFeaturesMessage : NetworkMessage
{

public const uint Id = 6305;
public override uint MessageId
{
    get { return Id; }
}

public short[] features;
        

public ServerOptionalFeaturesMessage()
{
}

public ServerOptionalFeaturesMessage(short[] features)
        {
            this.features = features;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)features.Length);
            foreach (var entry in features)
            {
                 writer.WriteShort(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            features = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 features[i] = reader.ReadShort();
            }
            

}


}


}