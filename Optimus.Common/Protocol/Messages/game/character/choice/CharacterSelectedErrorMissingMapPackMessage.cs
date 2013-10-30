


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharacterSelectedErrorMissingMapPackMessage : CharacterSelectedErrorMessage
{

public const uint Id = 6300;
public override uint MessageId
{
    get { return Id; }
}

public int subAreaId;
        

public CharacterSelectedErrorMissingMapPackMessage()
{
}

public CharacterSelectedErrorMissingMapPackMessage(int subAreaId)
        {
            this.subAreaId = subAreaId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(subAreaId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            subAreaId = reader.ReadInt();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            

}


}


}