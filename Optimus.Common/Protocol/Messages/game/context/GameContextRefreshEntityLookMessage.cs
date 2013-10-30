


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameContextRefreshEntityLookMessage : NetworkMessage
{

public const uint Id = 5637;
public override uint MessageId
{
    get { return Id; }
}

public int id;
        public Types.EntityLook look;
        

public GameContextRefreshEntityLookMessage()
{
}

public GameContextRefreshEntityLookMessage(int id, Types.EntityLook look)
        {
            this.id = id;
            this.look = look;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(id);
            look.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

id = reader.ReadInt();
            look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}