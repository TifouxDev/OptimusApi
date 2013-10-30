


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class HumanOption
{

public const short Id = 406;
public virtual short TypeId
{
    get { return Id; }
}



public HumanOption()
{
}



public virtual void Serialize(BigEndianWriter writer)
{



}

public virtual void Deserialize(BigEndianReader reader)
{



}


}


}