


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class GameRolePlayActorInformations : GameContextActorInformations
{

public const short Id = 141;
public override short TypeId
{
    get { return Id; }
}



public GameRolePlayActorInformations()
{
}

public GameRolePlayActorInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition)
         : base(contextualId, look, disposition)
        {
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            

}


}


}