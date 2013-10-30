


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class GameRolePlayNamedActorInformations : GameRolePlayActorInformations
{

public const short Id = 154;
public override short TypeId
{
    get { return Id; }
}

public string name;
        

public GameRolePlayNamedActorInformations()
{
}

public GameRolePlayNamedActorInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, string name)
         : base(contextualId, look, disposition)
        {
            this.name = name;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            

}


}


}