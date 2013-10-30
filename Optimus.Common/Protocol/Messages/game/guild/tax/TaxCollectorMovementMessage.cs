


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TaxCollectorMovementMessage : NetworkMessage
{

public const uint Id = 5633;
public override uint MessageId
{
    get { return Id; }
}

public bool hireOrFire;
        public Types.TaxCollectorBasicInformations basicInfos;
        public int playerId;
        public string playerName;
        

public TaxCollectorMovementMessage()
{
}

public TaxCollectorMovementMessage(bool hireOrFire, Types.TaxCollectorBasicInformations basicInfos, int playerId, string playerName)
        {
            this.hireOrFire = hireOrFire;
            this.basicInfos = basicInfos;
            this.playerId = playerId;
            this.playerName = playerName;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(hireOrFire);
            basicInfos.Serialize(writer);
            writer.WriteInt(playerId);
            writer.WriteUTF(playerName);
            

}

public override void Deserialize(BigEndianReader reader)
{

hireOrFire = reader.ReadBoolean();
            basicInfos = new Types.TaxCollectorBasicInformations();
            basicInfos.Deserialize(reader);
            playerId = reader.ReadInt();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            playerName = reader.ReadUTF();
            

}


}


}