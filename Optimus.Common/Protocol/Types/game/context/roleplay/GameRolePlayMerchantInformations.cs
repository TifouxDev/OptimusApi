


















// Generated on 10/27/2013 07:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class GameRolePlayMerchantInformations : GameRolePlayNamedActorInformations
{

public const short Id = 129;
public override short TypeId
{
    get { return Id; }
}

public int sellType;
        public Types.HumanOption[] options;
        

public GameRolePlayMerchantInformations()
{
}

public GameRolePlayMerchantInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, string name, int sellType, Types.HumanOption[] options)
         : base(contextualId, look, disposition, name)
        {
            this.sellType = sellType;
            this.options = options;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(sellType);
            writer.WriteUShort((ushort)options.Length);
            foreach (var entry in options)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            sellType = reader.ReadInt();
            if (sellType < 0)
                throw new Exception("Forbidden value on sellType = " + sellType + ", it doesn't respect the following condition : sellType < 0");
            var limit = reader.ReadUShort();
            options = new Types.HumanOption[limit];
            for (int i = 0; i < limit; i++)
            {
                 options[i] = Types.ProtocolTypeManager.GetInstance<Types.HumanOption>(reader.ReadShort());
                 options[i].Deserialize(reader);
            }
            

}


}


}