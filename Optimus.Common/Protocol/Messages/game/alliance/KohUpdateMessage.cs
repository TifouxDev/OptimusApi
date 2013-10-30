


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class KohUpdateMessage : NetworkMessage
{

public const uint Id = 6439;
public override uint MessageId
{
    get { return Id; }
}

public Types.AllianceInformations[] alliances;
        public short[] allianceNbMembers;
        public int[] allianceRoundWeigth;
        public sbyte[] allianceMatchScore;
        public Types.BasicAllianceInformations allianceMapWinner;
        public int allianceMapWinnerScore;
        public int allianceMapMyAllianceScore;
        

public KohUpdateMessage()
{
}

public KohUpdateMessage(Types.AllianceInformations[] alliances, short[] allianceNbMembers, int[] allianceRoundWeigth, sbyte[] allianceMatchScore, Types.BasicAllianceInformations allianceMapWinner, int allianceMapWinnerScore, int allianceMapMyAllianceScore)
        {
            this.alliances = alliances;
            this.allianceNbMembers = allianceNbMembers;
            this.allianceRoundWeigth = allianceRoundWeigth;
            this.allianceMatchScore = allianceMatchScore;
            this.allianceMapWinner = allianceMapWinner;
            this.allianceMapWinnerScore = allianceMapWinnerScore;
            this.allianceMapMyAllianceScore = allianceMapMyAllianceScore;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)alliances.Length);
            foreach (var entry in alliances)
            {
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)allianceNbMembers.Length);
            foreach (var entry in allianceNbMembers)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteUShort((ushort)allianceRoundWeigth.Length);
            foreach (var entry in allianceRoundWeigth)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteUShort((ushort)allianceMatchScore.Length);
            foreach (var entry in allianceMatchScore)
            {
                 writer.WriteSByte(entry);
            }
            allianceMapWinner.Serialize(writer);
            writer.WriteInt(allianceMapWinnerScore);
            writer.WriteInt(allianceMapMyAllianceScore);
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            alliances = new Types.AllianceInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliances[i] = new Types.AllianceInformations();
                 alliances[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            allianceNbMembers = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 allianceNbMembers[i] = reader.ReadShort();
            }
            limit = reader.ReadUShort();
            allianceRoundWeigth = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 allianceRoundWeigth[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            allianceMatchScore = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 allianceMatchScore[i] = reader.ReadSByte();
            }
            allianceMapWinner = new Types.BasicAllianceInformations();
            allianceMapWinner.Deserialize(reader);
            allianceMapWinnerScore = reader.ReadInt();
            if (allianceMapWinnerScore < 0)
                throw new Exception("Forbidden value on allianceMapWinnerScore = " + allianceMapWinnerScore + ", it doesn't respect the following condition : allianceMapWinnerScore < 0");
            allianceMapMyAllianceScore = reader.ReadInt();
            if (allianceMapMyAllianceScore < 0)
                throw new Exception("Forbidden value on allianceMapMyAllianceScore = " + allianceMapMyAllianceScore + ", it doesn't respect the following condition : allianceMapMyAllianceScore < 0");
            

}


}


}