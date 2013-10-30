


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class EntityMovementInformations
{

public const short Id = 63;
public virtual short TypeId
{
    get { return Id; }
}

public int id;
        public sbyte[] steps;
        

public EntityMovementInformations()
{
}

public EntityMovementInformations(int id, sbyte[] steps)
        {
            this.id = id;
            this.steps = steps;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteInt(id);
            writer.WriteUShort((ushort)steps.Length);
            foreach (var entry in steps)
            {
                 writer.WriteSByte(entry);
            }
            

}

public virtual void Deserialize(BigEndianReader reader)
{

id = reader.ReadInt();
            var limit = reader.ReadUShort();
            steps = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 steps[i] = reader.ReadSByte();
            }
            

}


}


}