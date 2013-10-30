


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class CharacterBaseInformations : CharacterMinimalPlusLookInformations
{

public const short Id = 45;
public override short TypeId
{
    get { return Id; }
}

public sbyte breed;
        public bool sex;
        

public CharacterBaseInformations()
{
}

public CharacterBaseInformations(int id, byte level, string name, Types.EntityLook entityLook, sbyte breed, bool sex)
         : base(id, level, name, entityLook)
        {
            this.breed = breed;
            this.sex = sex;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
            

}


}


}