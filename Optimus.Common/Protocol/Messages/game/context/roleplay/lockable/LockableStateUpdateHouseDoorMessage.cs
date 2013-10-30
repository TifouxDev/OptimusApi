


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class LockableStateUpdateHouseDoorMessage : LockableStateUpdateAbstractMessage
{

public const uint Id = 5668;
public override uint MessageId
{
    get { return Id; }
}

public int houseId;
        

public LockableStateUpdateHouseDoorMessage()
{
}

public LockableStateUpdateHouseDoorMessage(bool locked, int houseId)
         : base(locked)
        {
            this.houseId = houseId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(houseId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            houseId = reader.ReadInt();
            

}


}


}