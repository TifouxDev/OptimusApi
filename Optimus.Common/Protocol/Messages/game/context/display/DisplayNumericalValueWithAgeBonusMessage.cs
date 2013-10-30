


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class DisplayNumericalValueWithAgeBonusMessage : DisplayNumericalValueMessage
{

public const uint Id = 6361;
public override uint MessageId
{
    get { return Id; }
}

public int valueOfBonus;
        

public DisplayNumericalValueWithAgeBonusMessage()
{
}

public DisplayNumericalValueWithAgeBonusMessage(int entityId, int value, sbyte type, int valueOfBonus)
         : base(entityId, value, type)
        {
            this.valueOfBonus = valueOfBonus;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(valueOfBonus);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            valueOfBonus = reader.ReadInt();
            

}


}


}