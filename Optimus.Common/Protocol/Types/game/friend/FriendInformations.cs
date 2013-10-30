


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FriendInformations : AbstractContactInformations
{

public const short Id = 78;
public override short TypeId
{
    get { return Id; }
}

public sbyte playerState;
        public int lastConnection;
        public int achievementPoints;
        

public FriendInformations()
{
}

public FriendInformations(int accountId, string accountName, sbyte playerState, int lastConnection, int achievementPoints)
         : base(accountId, accountName)
        {
            this.playerState = playerState;
            this.lastConnection = lastConnection;
            this.achievementPoints = achievementPoints;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(playerState);
            writer.WriteInt(lastConnection);
            writer.WriteInt(achievementPoints);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            playerState = reader.ReadSByte();
            if (playerState < 0)
                throw new Exception("Forbidden value on playerState = " + playerState + ", it doesn't respect the following condition : playerState < 0");
            lastConnection = reader.ReadInt();
            if (lastConnection < 0)
                throw new Exception("Forbidden value on lastConnection = " + lastConnection + ", it doesn't respect the following condition : lastConnection < 0");
            achievementPoints = reader.ReadInt();
            

}


}


}