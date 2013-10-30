


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class SelectedServerRefusedMessage : NetworkMessage
{

public const uint Id = 41;
public override uint MessageId
{
    get { return Id; }
}

public short serverId;
        public sbyte error;
        public sbyte serverStatus;
        

public SelectedServerRefusedMessage()
{
}

public SelectedServerRefusedMessage(short serverId, sbyte error, sbyte serverStatus)
        {
            this.serverId = serverId;
            this.error = error;
            this.serverStatus = serverStatus;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(serverId);
            writer.WriteSByte(error);
            writer.WriteSByte(serverStatus);
            

}

public override void Deserialize(BigEndianReader reader)
{

serverId = reader.ReadShort();
            error = reader.ReadSByte();
            if (error < 0)
                throw new Exception("Forbidden value on error = " + error + ", it doesn't respect the following condition : error < 0");
            serverStatus = reader.ReadSByte();
            if (serverStatus < 0)
                throw new Exception("Forbidden value on serverStatus = " + serverStatus + ", it doesn't respect the following condition : serverStatus < 0");
            

}


}


}