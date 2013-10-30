


















// Generated on 10/27/2013 07:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightCloseCombatMessage : AbstractGameActionFightTargetedAbilityMessage
{

public const uint Id = 6116;
public override uint MessageId
{
    get { return Id; }
}

public int weaponGenericId;
        

public GameActionFightCloseCombatMessage()
{
}

public GameActionFightCloseCombatMessage(short actionId, int sourceId, int targetId, short destinationCellId, sbyte critical, bool silentCast, int weaponGenericId)
         : base(actionId, sourceId, targetId, destinationCellId, critical, silentCast)
        {
            this.weaponGenericId = weaponGenericId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(weaponGenericId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            weaponGenericId = reader.ReadInt();
            if (weaponGenericId < 0)
                throw new Exception("Forbidden value on weaponGenericId = " + weaponGenericId + ", it doesn't respect the following condition : weaponGenericId < 0");
            

}


}


}