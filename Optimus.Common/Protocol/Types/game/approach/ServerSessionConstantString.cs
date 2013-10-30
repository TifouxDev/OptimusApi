


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ServerSessionConstantString : ServerSessionConstant
{

public const short Id = 436;
public override short TypeId
{
    get { return Id; }
}

public string value;
        

public ServerSessionConstantString()
{
}

public ServerSessionConstantString(short id, string value)
         : base(id)
        {
            this.value = value;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(value);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            value = reader.ReadUTF();
            

}


}


}