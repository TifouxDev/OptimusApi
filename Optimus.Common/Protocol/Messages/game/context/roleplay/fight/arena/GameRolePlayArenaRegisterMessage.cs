


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameRolePlayArenaRegisterMessage : NetworkMessage
{

public const uint Id = 6280;
public override uint MessageId
{
    get { return Id; }
}

public int battleMode;
        

public GameRolePlayArenaRegisterMessage()
{
}

public GameRolePlayArenaRegisterMessage(int battleMode)
        {
            this.battleMode = battleMode;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(battleMode);
            

}

public override void Deserialize(BigEndianReader reader)
{

battleMode = reader.ReadInt();
            if (battleMode < 0)
                throw new Exception("Forbidden value on battleMode = " + battleMode + ", it doesn't respect the following condition : battleMode < 0");
            

}


}


}