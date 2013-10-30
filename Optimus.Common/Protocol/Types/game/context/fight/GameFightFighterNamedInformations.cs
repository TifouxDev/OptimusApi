


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class GameFightFighterNamedInformations : GameFightFighterInformations
{

public const short Id = 158;
public override short TypeId
{
    get { return Id; }
}

public string name;
        public Types.PlayerStatus status;
        

public GameFightFighterNamedInformations()
{
}

public GameFightFighterNamedInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, bool alive, Types.GameFightMinimalStats stats, string name, Types.PlayerStatus status)
         : base(contextualId, look, disposition, teamId, alive, stats)
        {
            this.name = name;
            this.status = status;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            status.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            status = new Types.PlayerStatus();
            status.Deserialize(reader);
            

}


}


}