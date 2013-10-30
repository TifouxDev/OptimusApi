


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ZaapListMessage : TeleportDestinationsListMessage
{

public const uint Id = 1604;
public override uint MessageId
{
    get { return Id; }
}

public int spawnMapId;
        

public ZaapListMessage()
{
}

public ZaapListMessage(sbyte teleporterType, int[] mapIds, short[] subAreaIds, short[] costs, sbyte[] destTeleporterType, int spawnMapId)
         : base(teleporterType, mapIds, subAreaIds, costs, destTeleporterType)
        {
            this.spawnMapId = spawnMapId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(spawnMapId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            spawnMapId = reader.ReadInt();
            if (spawnMapId < 0)
                throw new Exception("Forbidden value on spawnMapId = " + spawnMapId + ", it doesn't respect the following condition : spawnMapId < 0");
            

}


}


}