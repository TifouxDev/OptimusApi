


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeObjectModifiedMessage : ExchangeObjectMessage
{

public const uint Id = 5519;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem @object;
        

public ExchangeObjectModifiedMessage()
{
}

public ExchangeObjectModifiedMessage(bool remote, Types.ObjectItem @object)
         : base(remote)
        {
            this.@object = @object;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            @object.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            @object = new Types.ObjectItem();
            @object.Deserialize(reader);
            

}


}


}