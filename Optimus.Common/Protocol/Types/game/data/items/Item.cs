


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class Item
{

public const short Id = 7;
public virtual short TypeId
{
    get { return Id; }
}



public Item()
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