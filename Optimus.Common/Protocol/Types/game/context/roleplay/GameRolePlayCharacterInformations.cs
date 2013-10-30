


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class GameRolePlayCharacterInformations : GameRolePlayHumanoidInformations
{

public const short Id = 36;
public override short TypeId
{
    get { return Id; }
}

public Types.ActorAlignmentInformations alignmentInfos;
        

public GameRolePlayCharacterInformations()
{
}

public GameRolePlayCharacterInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, string name, Types.HumanInformations humanoidInfo, int accountId, Types.ActorAlignmentInformations alignmentInfos)
         : base(contextualId, look, disposition, name, humanoidInfo, accountId)
        {
            this.alignmentInfos = alignmentInfos;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            alignmentInfos.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            alignmentInfos = new Types.ActorAlignmentInformations();
            alignmentInfos.Deserialize(reader);
            

}


}


}