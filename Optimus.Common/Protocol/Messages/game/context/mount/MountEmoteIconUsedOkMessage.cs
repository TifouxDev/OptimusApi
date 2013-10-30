


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MountEmoteIconUsedOkMessage : NetworkMessage
{

public const uint Id = 5978;
public override uint MessageId
{
    get { return Id; }
}

public int mountId;
        public sbyte reactionType;
        

public MountEmoteIconUsedOkMessage()
{
}

public MountEmoteIconUsedOkMessage(int mountId, sbyte reactionType)
        {
            this.mountId = mountId;
            this.reactionType = reactionType;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(mountId);
            writer.WriteSByte(reactionType);
            

}

public override void Deserialize(BigEndianReader reader)
{

mountId = reader.ReadInt();
            reactionType = reader.ReadSByte();
            if (reactionType < 0)
                throw new Exception("Forbidden value on reactionType = " + reactionType + ", it doesn't respect the following condition : reactionType < 0");
            

}


}


}