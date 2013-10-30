


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AccountCapabilitiesMessage : NetworkMessage
{

public const uint Id = 6216;
public override uint MessageId
{
    get { return Id; }
}

public int accountId;
        public bool tutorialAvailable;
        public short breedsVisible;
        public short breedsAvailable;
        public sbyte status;
        

public AccountCapabilitiesMessage()
{
}

public AccountCapabilitiesMessage(int accountId, bool tutorialAvailable, short breedsVisible, short breedsAvailable, sbyte status)
        {
            this.accountId = accountId;
            this.tutorialAvailable = tutorialAvailable;
            this.breedsVisible = breedsVisible;
            this.breedsAvailable = breedsAvailable;
            this.status = status;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteBoolean(tutorialAvailable);
            writer.WriteShort(breedsVisible);
            writer.WriteShort(breedsAvailable);
            writer.WriteSByte(status);
            

}

public override void Deserialize(BigEndianReader reader)
{

accountId = reader.ReadInt();
            tutorialAvailable = reader.ReadBoolean();
            breedsVisible = reader.ReadShort();
            if (breedsVisible < 0)
                throw new Exception("Forbidden value on breedsVisible = " + breedsVisible + ", it doesn't respect the following condition : breedsVisible < 0");
            breedsAvailable = reader.ReadShort();
            if (breedsAvailable < 0)
                throw new Exception("Forbidden value on breedsAvailable = " + breedsAvailable + ", it doesn't respect the following condition : breedsAvailable < 0");
            status = reader.ReadSByte();
            

}


}


}