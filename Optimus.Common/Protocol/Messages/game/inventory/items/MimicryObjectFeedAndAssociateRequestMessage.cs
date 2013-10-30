


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MimicryObjectFeedAndAssociateRequestMessage : NetworkMessage
{

public const uint Id = 6460;
public override uint MessageId
{
    get { return Id; }
}

public int mimicryUID;
        public byte mimicryPos;
        public int foodUID;
        public byte foodPos;
        public int hostUID;
        public byte hostPos;
        public bool preview;
        

public MimicryObjectFeedAndAssociateRequestMessage()
{
}

public MimicryObjectFeedAndAssociateRequestMessage(int mimicryUID, byte mimicryPos, int foodUID, byte foodPos, int hostUID, byte hostPos, bool preview)
        {
            this.mimicryUID = mimicryUID;
            this.mimicryPos = mimicryPos;
            this.foodUID = foodUID;
            this.foodPos = foodPos;
            this.hostUID = hostUID;
            this.hostPos = hostPos;
            this.preview = preview;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(mimicryUID);
            writer.WriteByte(mimicryPos);
            writer.WriteInt(foodUID);
            writer.WriteByte(foodPos);
            writer.WriteInt(hostUID);
            writer.WriteByte(hostPos);
            writer.WriteBoolean(preview);
            

}

public override void Deserialize(BigEndianReader reader)
{

mimicryUID = reader.ReadInt();
            if (mimicryUID < 0)
                throw new Exception("Forbidden value on mimicryUID = " + mimicryUID + ", it doesn't respect the following condition : mimicryUID < 0");
            mimicryPos = reader.ReadByte();
            if (mimicryPos < 0 || mimicryPos > 255)
                throw new Exception("Forbidden value on mimicryPos = " + mimicryPos + ", it doesn't respect the following condition : mimicryPos < 0 || mimicryPos > 255");
            foodUID = reader.ReadInt();
            if (foodUID < 0)
                throw new Exception("Forbidden value on foodUID = " + foodUID + ", it doesn't respect the following condition : foodUID < 0");
            foodPos = reader.ReadByte();
            if (foodPos < 0 || foodPos > 255)
                throw new Exception("Forbidden value on foodPos = " + foodPos + ", it doesn't respect the following condition : foodPos < 0 || foodPos > 255");
            hostUID = reader.ReadInt();
            if (hostUID < 0)
                throw new Exception("Forbidden value on hostUID = " + hostUID + ", it doesn't respect the following condition : hostUID < 0");
            hostPos = reader.ReadByte();
            if (hostPos < 0 || hostPos > 255)
                throw new Exception("Forbidden value on hostPos = " + hostPos + ", it doesn't respect the following condition : hostPos < 0 || hostPos > 255");
            preview = reader.ReadBoolean();
            

}


}


}