


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ShowCellSpectatorMessage : ShowCellMessage
{

public const uint Id = 6158;
public override uint MessageId
{
    get { return Id; }
}

public string playerName;
        

public ShowCellSpectatorMessage()
{
}

public ShowCellSpectatorMessage(int sourceId, short cellId, string playerName)
         : base(sourceId, cellId)
        {
            this.playerName = playerName;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(playerName);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            playerName = reader.ReadUTF();
            

}


}


}