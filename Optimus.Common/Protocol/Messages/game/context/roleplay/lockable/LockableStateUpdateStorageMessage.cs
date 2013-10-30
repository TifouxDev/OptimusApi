


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class LockableStateUpdateStorageMessage : LockableStateUpdateAbstractMessage
{

public const uint Id = 5669;
public override uint MessageId
{
    get { return Id; }
}

public int mapId;
        public int elementId;
        

public LockableStateUpdateStorageMessage()
{
}

public LockableStateUpdateStorageMessage(bool locked, int mapId, int elementId)
         : base(locked)
        {
            this.mapId = mapId;
            this.elementId = elementId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(mapId);
            writer.WriteInt(elementId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            mapId = reader.ReadInt();
            elementId = reader.ReadInt();
            if (elementId < 0)
                throw new Exception("Forbidden value on elementId = " + elementId + ", it doesn't respect the following condition : elementId < 0");
            

}


}


}