


















// Generated on 10/27/2013 07:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangePlayerMultiCraftRequestMessage : ExchangeRequestMessage
{

public const uint Id = 5784;
public override uint MessageId
{
    get { return Id; }
}

public int target;
        public int skillId;
        

public ExchangePlayerMultiCraftRequestMessage()
{
}

public ExchangePlayerMultiCraftRequestMessage(sbyte exchangeType, int target, int skillId)
         : base(exchangeType)
        {
            this.target = target;
            this.skillId = skillId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(target);
            writer.WriteInt(skillId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            target = reader.ReadInt();
            if (target < 0)
                throw new Exception("Forbidden value on target = " + target + ", it doesn't respect the following condition : target < 0");
            skillId = reader.ReadInt();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            

}


}


}