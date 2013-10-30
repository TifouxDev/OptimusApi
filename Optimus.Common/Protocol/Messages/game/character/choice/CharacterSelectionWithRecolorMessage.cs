


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharacterSelectionWithRecolorMessage : CharacterSelectionMessage
{

public const uint Id = 6075;
public override uint MessageId
{
    get { return Id; }
}

public int[] indexedColor;
        

public CharacterSelectionWithRecolorMessage()
{
}

public CharacterSelectionWithRecolorMessage(int id, int[] indexedColor)
         : base(id)
        {
            this.indexedColor = indexedColor;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)indexedColor.Length);
            foreach (var entry in indexedColor)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            indexedColor = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 indexedColor[i] = reader.ReadInt();
            }
            

}


}


}