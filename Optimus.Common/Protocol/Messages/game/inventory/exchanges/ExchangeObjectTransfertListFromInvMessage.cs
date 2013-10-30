


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeObjectTransfertListFromInvMessage : NetworkMessage
{

public const uint Id = 6183;
public override uint MessageId
{
    get { return Id; }
}

public int[] ids;
        

public ExchangeObjectTransfertListFromInvMessage()
{
}

public ExchangeObjectTransfertListFromInvMessage(int[] ids)
        {
            this.ids = ids;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            ids = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadInt();
            }
            

}


}


}