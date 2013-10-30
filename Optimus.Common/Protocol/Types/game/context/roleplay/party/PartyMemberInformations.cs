


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class PartyMemberInformations : CharacterBaseInformations
{

public const short Id = 90;
public override short TypeId
{
    get { return Id; }
}

public int lifePoints;
        public int maxLifePoints;
        public short prospecting;
        public byte regenRate;
        public short initiative;
        public sbyte alignmentSide;
        public short worldX;
        public short worldY;
        public int mapId;
        public short subAreaId;
        public Types.PlayerStatus status;
        

public PartyMemberInformations()
{
}

public PartyMemberInformations(int id, byte level, string name, Types.EntityLook entityLook, sbyte breed, bool sex, int lifePoints, int maxLifePoints, short prospecting, byte regenRate, short initiative, sbyte alignmentSide, short worldX, short worldY, int mapId, short subAreaId, Types.PlayerStatus status)
         : base(id, level, name, entityLook, breed, sex)
        {
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
            this.prospecting = prospecting;
            this.regenRate = regenRate;
            this.initiative = initiative;
            this.alignmentSide = alignmentSide;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.status = status;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(lifePoints);
            writer.WriteInt(maxLifePoints);
            writer.WriteShort(prospecting);
            writer.WriteByte(regenRate);
            writer.WriteShort(initiative);
            writer.WriteSByte(alignmentSide);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteShort(subAreaId);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            lifePoints = reader.ReadInt();
            if (lifePoints < 0)
                throw new Exception("Forbidden value on lifePoints = " + lifePoints + ", it doesn't respect the following condition : lifePoints < 0");
            maxLifePoints = reader.ReadInt();
            if (maxLifePoints < 0)
                throw new Exception("Forbidden value on maxLifePoints = " + maxLifePoints + ", it doesn't respect the following condition : maxLifePoints < 0");
            prospecting = reader.ReadShort();
            if (prospecting < 0)
                throw new Exception("Forbidden value on prospecting = " + prospecting + ", it doesn't respect the following condition : prospecting < 0");
            regenRate = reader.ReadByte();
            if (regenRate < 0 || regenRate > 255)
                throw new Exception("Forbidden value on regenRate = " + regenRate + ", it doesn't respect the following condition : regenRate < 0 || regenRate > 255");
            initiative = reader.ReadShort();
            if (initiative < 0)
                throw new Exception("Forbidden value on initiative = " + initiative + ", it doesn't respect the following condition : initiative < 0");
            alignmentSide = reader.ReadSByte();
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            mapId = reader.ReadInt();
            subAreaId = reader.ReadShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            status = Types.ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadShort());
            status.Deserialize(reader);
            

}


}


}