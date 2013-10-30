


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ObjectItemMinimalInformation : Item
{

public const short Id = 124;
public override short TypeId
{
    get { return Id; }
}

public short objectGID;
        public Types.ObjectEffect[] effects;
        

public ObjectItemMinimalInformation()
{
}

public ObjectItemMinimalInformation(short objectGID, Types.ObjectEffect[] effects)
        {
            this.objectGID = objectGID;
            this.effects = effects;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(objectGID);
            writer.WriteUShort((ushort)effects.Length);
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            objectGID = reader.ReadShort();
            if (objectGID < 0)
                throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            var limit = reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = Types.ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadShort());
                 effects[i].Deserialize(reader);
            }
            

}


}


}