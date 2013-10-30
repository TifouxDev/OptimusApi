


















// Generated on 10/27/2013 07:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightDispellableEffectMessage : AbstractGameActionMessage
{

public const uint Id = 6070;
public override uint MessageId
{
    get { return Id; }
}

public Types.AbstractFightDispellableEffect effect;
        

public GameActionFightDispellableEffectMessage()
{
}

public GameActionFightDispellableEffectMessage(short actionId, int sourceId, Types.AbstractFightDispellableEffect effect)
         : base(actionId, sourceId)
        {
            this.effect = effect;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(effect.TypeId);
            effect.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            effect = Types.ProtocolTypeManager.GetInstance<Types.AbstractFightDispellableEffect>(reader.ReadShort());
            effect.Deserialize(reader);
            

}


}


}