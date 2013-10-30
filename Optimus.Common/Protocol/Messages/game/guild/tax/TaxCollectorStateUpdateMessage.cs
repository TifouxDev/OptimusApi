


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TaxCollectorStateUpdateMessage : NetworkMessage
{

public const uint Id = 6455;
public override uint MessageId
{
    get { return Id; }
}

public int uniqueId;
        public sbyte state;
        

public TaxCollectorStateUpdateMessage()
{
}

public TaxCollectorStateUpdateMessage(int uniqueId, sbyte state)
        {
            this.uniqueId = uniqueId;
            this.state = state;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(uniqueId);
            writer.WriteSByte(state);
            

}

public override void Deserialize(BigEndianReader reader)
{

uniqueId = reader.ReadInt();
            state = reader.ReadSByte();
            

}


}


}