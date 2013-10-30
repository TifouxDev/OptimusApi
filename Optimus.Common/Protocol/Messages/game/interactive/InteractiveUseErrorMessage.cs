


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class InteractiveUseErrorMessage : NetworkMessage
{

public const uint Id = 6384;
public override uint MessageId
{
    get { return Id; }
}

public int elemId;
        public int skillInstanceUid;
        

public InteractiveUseErrorMessage()
{
}

public InteractiveUseErrorMessage(int elemId, int skillInstanceUid)
        {
            this.elemId = elemId;
            this.skillInstanceUid = skillInstanceUid;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(elemId);
            writer.WriteInt(skillInstanceUid);
            

}

public override void Deserialize(BigEndianReader reader)
{

elemId = reader.ReadInt();
            if (elemId < 0)
                throw new Exception("Forbidden value on elemId = " + elemId + ", it doesn't respect the following condition : elemId < 0");
            skillInstanceUid = reader.ReadInt();
            if (skillInstanceUid < 0)
                throw new Exception("Forbidden value on skillInstanceUid = " + skillInstanceUid + ", it doesn't respect the following condition : skillInstanceUid < 0");
            

}


}


}