


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class NicknameChoiceRequestMessage : NetworkMessage
{

public const uint Id = 5639;
public override uint MessageId
{
    get { return Id; }
}

public string nickname;
        

public NicknameChoiceRequestMessage()
{
}

public NicknameChoiceRequestMessage(string nickname)
        {
            this.nickname = nickname;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(nickname);
            

}

public override void Deserialize(BigEndianReader reader)
{

nickname = reader.ReadUTF();
            

}


}


}