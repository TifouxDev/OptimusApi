


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MimicryObjectEraseRequestMessage : NetworkMessage
{

public const uint Id = 6457;
public override uint MessageId
{
    get { return Id; }
}

public int hostUID;
        public byte hostPos;
        

public MimicryObjectEraseRequestMessage()
{
}

public MimicryObjectEraseRequestMessage(int hostUID, byte hostPos)
        {
            this.hostUID = hostUID;
            this.hostPos = hostPos;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(hostUID);
            writer.WriteByte(hostPos);
            

}

public override void Deserialize(BigEndianReader reader)
{

hostUID = reader.ReadInt();
            if (hostUID < 0)
                throw new Exception("Forbidden value on hostUID = " + hostUID + ", it doesn't respect the following condition : hostUID < 0");
            hostPos = reader.ReadByte();
            if (hostPos < 0 || hostPos > 255)
                throw new Exception("Forbidden value on hostPos = " + hostPos + ", it doesn't respect the following condition : hostPos < 0 || hostPos > 255");
            

}


}


}