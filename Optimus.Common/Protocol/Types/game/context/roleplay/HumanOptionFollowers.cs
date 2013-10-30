


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class HumanOptionFollowers : HumanOption
{

public const short Id = 410;
public override short TypeId
{
    get { return Id; }
}

public Types.IndexedEntityLook[] followingCharactersLook;
        

public HumanOptionFollowers()
{
}

public HumanOptionFollowers(Types.IndexedEntityLook[] followingCharactersLook)
        {
            this.followingCharactersLook = followingCharactersLook;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)followingCharactersLook.Length);
            foreach (var entry in followingCharactersLook)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            followingCharactersLook = new Types.IndexedEntityLook[limit];
            for (int i = 0; i < limit; i++)
            {
                 followingCharactersLook[i] = new Types.IndexedEntityLook();
                 followingCharactersLook[i].Deserialize(reader);
            }
            

}


}


}