


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FightTeamMemberInformations
{

public const short Id = 44;
public virtual short TypeId
{
    get { return Id; }
}

public int id;
        

public FightTeamMemberInformations()
{
}

public FightTeamMemberInformations(int id)
        {
            this.id = id;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteInt(id);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

id = reader.ReadInt();
            

}


}


}