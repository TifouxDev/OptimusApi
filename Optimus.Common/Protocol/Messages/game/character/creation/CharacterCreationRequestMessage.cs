


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharacterCreationRequestMessage : NetworkMessage
{

public const uint Id = 160;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public sbyte breed;
        public bool sex;
        public int[] colors;
        public int cosmeticId;
        

public CharacterCreationRequestMessage()
{
}

public CharacterCreationRequestMessage(string name, sbyte breed, bool sex, int[] colors, int cosmeticId)
        {
            this.name = name;
            this.breed = breed;
            this.sex = sex;
            this.colors = colors;
            this.cosmeticId = cosmeticId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(name);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            writer.WriteUShort((ushort)colors.Length);
            foreach (var entry in colors)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteInt(cosmeticId);
            

}

public override void Deserialize(BigEndianReader reader)
{

name = reader.ReadUTF();
            breed = reader.ReadSByte();
            if (breed < (byte)Enums.PlayableBreedEnum.Feca || breed > (byte)Enums.PlayableBreedEnum.Steamer)
                throw new Exception("Forbidden value on breed = " + breed + ", it doesn't respect the following condition : breed < (byte)Enums.PlayableBreedEnum.Feca || breed > (byte)Enums.PlayableBreedEnum.Steamer");
            sex = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            colors = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 colors[i] = reader.ReadInt();
            }
            cosmeticId = reader.ReadInt();
            if (cosmeticId < 0)
                throw new Exception("Forbidden value on cosmeticId = " + cosmeticId + ", it doesn't respect the following condition : cosmeticId < 0");
            

}


}


}