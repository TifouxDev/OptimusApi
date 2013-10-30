


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameRolePlayDelayedObjectUseMessage : GameRolePlayDelayedActionMessage
{

public const uint Id = 6425;
public override uint MessageId
{
    get { return Id; }
}

public short objectGID;
        

public GameRolePlayDelayedObjectUseMessage()
{
}

public GameRolePlayDelayedObjectUseMessage(int delayedCharacterId, sbyte delayTypeId, double delayEndTime, short objectGID)
         : base(delayedCharacterId, delayTypeId, delayEndTime)
        {
            this.objectGID = objectGID;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(objectGID);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            objectGID = reader.ReadShort();
            if (objectGID < 0)
                throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            

}


}


}