


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AccountHouseMessage : NetworkMessage
{

public const uint Id = 6315;
public override uint MessageId
{
    get { return Id; }
}

public Types.AccountHouseInformations[] houses;
        

public AccountHouseMessage()
{
}

public AccountHouseMessage(Types.AccountHouseInformations[] houses)
        {
            this.houses = houses;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)houses.Length);
            foreach (var entry in houses)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            houses = new Types.AccountHouseInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 houses[i] = new Types.AccountHouseInformations();
                 houses[i].Deserialize(reader);
            }
            

}


}


}