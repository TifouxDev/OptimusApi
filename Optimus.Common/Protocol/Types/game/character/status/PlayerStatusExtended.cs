


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class PlayerStatusExtended : PlayerStatus
{

public const short Id = 414;
public override short TypeId
{
    get { return Id; }
}

public string message;
        

public PlayerStatusExtended()
{
}

public PlayerStatusExtended(sbyte statusId, string message)
         : base(statusId)
        {
            this.message = message;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(message);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            message = reader.ReadUTF();
            

}


}


}