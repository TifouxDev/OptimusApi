


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameRolePlayDelayedActionMessage : NetworkMessage
{

public const uint Id = 6153;
public override uint MessageId
{
    get { return Id; }
}

public int delayedCharacterId;
        public sbyte delayTypeId;
        public double delayEndTime;
        

public GameRolePlayDelayedActionMessage()
{
}

public GameRolePlayDelayedActionMessage(int delayedCharacterId, sbyte delayTypeId, double delayEndTime)
        {
            this.delayedCharacterId = delayedCharacterId;
            this.delayTypeId = delayTypeId;
            this.delayEndTime = delayEndTime;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(delayedCharacterId);
            writer.WriteSByte(delayTypeId);
            writer.WriteDouble(delayEndTime);
            

}

public override void Deserialize(BigEndianReader reader)
{

delayedCharacterId = reader.ReadInt();
            delayTypeId = reader.ReadSByte();
            if (delayTypeId < 0)
                throw new Exception("Forbidden value on delayTypeId = " + delayTypeId + ", it doesn't respect the following condition : delayTypeId < 0");
            delayEndTime = reader.ReadDouble();
            if (delayEndTime < 0)
                throw new Exception("Forbidden value on delayEndTime = " + delayEndTime + ", it doesn't respect the following condition : delayEndTime < 0");
            

}


}


}