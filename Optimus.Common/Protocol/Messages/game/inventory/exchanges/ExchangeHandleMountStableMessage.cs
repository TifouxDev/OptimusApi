


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeHandleMountStableMessage : NetworkMessage
{

public const uint Id = 5965;
public override uint MessageId
{
    get { return Id; }
}

public sbyte actionType;
        public int rideId;
        

public ExchangeHandleMountStableMessage()
{
}

public ExchangeHandleMountStableMessage(sbyte actionType, int rideId)
        {
            this.actionType = actionType;
            this.rideId = rideId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(actionType);
            writer.WriteInt(rideId);
            

}

public override void Deserialize(BigEndianReader reader)
{

actionType = reader.ReadSByte();
            rideId = reader.ReadInt();
            if (rideId < 0)
                throw new Exception("Forbidden value on rideId = " + rideId + ", it doesn't respect the following condition : rideId < 0");
            

}


}


}