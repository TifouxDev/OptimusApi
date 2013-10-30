


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeTypesExchangerDescriptionForUserMessage : NetworkMessage
{

public const uint Id = 5765;
public override uint MessageId
{
    get { return Id; }
}

public int[] typeDescription;
        

public ExchangeTypesExchangerDescriptionForUserMessage()
{
}

public ExchangeTypesExchangerDescriptionForUserMessage(int[] typeDescription)
        {
            this.typeDescription = typeDescription;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)typeDescription.Length);
            foreach (var entry in typeDescription)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            typeDescription = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 typeDescription[i] = reader.ReadInt();
            }
            

}


}


}