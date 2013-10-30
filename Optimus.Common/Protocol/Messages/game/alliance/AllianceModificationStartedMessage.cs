


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceModificationStartedMessage : NetworkMessage
{

public const uint Id = 6444;
public override uint MessageId
{
    get { return Id; }
}

public bool canChangeName;
        public bool canChangeTag;
        public bool canChangeEmblem;
        

public AllianceModificationStartedMessage()
{
}

public AllianceModificationStartedMessage(bool canChangeName, bool canChangeTag, bool canChangeEmblem)
        {
            this.canChangeName = canChangeName;
            this.canChangeTag = canChangeTag;
            this.canChangeEmblem = canChangeEmblem;
        }
        

public override void Serialize(BigEndianWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, canChangeName);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, canChangeTag);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 2, canChangeEmblem);
            writer.WriteByte(flag1);
            

}

public override void Deserialize(BigEndianReader reader)
{

byte flag1 = reader.ReadByte();
            canChangeName = BooleanByteWrapper.GetFlag(flag1, 0);
            canChangeTag = BooleanByteWrapper.GetFlag(flag1, 1);
            canChangeEmblem = BooleanByteWrapper.GetFlag(flag1, 2);
            

}


}


}