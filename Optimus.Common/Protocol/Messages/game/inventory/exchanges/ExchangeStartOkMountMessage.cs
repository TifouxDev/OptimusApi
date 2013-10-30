


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeStartOkMountMessage : ExchangeStartOkMountWithOutPaddockMessage
{

public const uint Id = 5979;
public override uint MessageId
{
    get { return Id; }
}

public Types.MountClientData[] paddockedMountsDescription;
        

public ExchangeStartOkMountMessage()
{
}

public ExchangeStartOkMountMessage(Types.MountClientData[] stabledMountsDescription, Types.MountClientData[] paddockedMountsDescription)
         : base(stabledMountsDescription)
        {
            this.paddockedMountsDescription = paddockedMountsDescription;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)paddockedMountsDescription.Length);
            foreach (var entry in paddockedMountsDescription)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            paddockedMountsDescription = new Types.MountClientData[limit];
            for (int i = 0; i < limit; i++)
            {
                 paddockedMountsDescription[i] = new Types.MountClientData();
                 paddockedMountsDescription[i].Deserialize(reader);
            }
            

}


}


}