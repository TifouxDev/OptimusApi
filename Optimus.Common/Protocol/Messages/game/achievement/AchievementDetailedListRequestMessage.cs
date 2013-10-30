


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AchievementDetailedListRequestMessage : NetworkMessage
{

public const uint Id = 6357;
public override uint MessageId
{
    get { return Id; }
}

public short categoryId;
        

public AchievementDetailedListRequestMessage()
{
}

public AchievementDetailedListRequestMessage(short categoryId)
        {
            this.categoryId = categoryId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(categoryId);
            

}

public override void Deserialize(BigEndianReader reader)
{

categoryId = reader.ReadShort();
            if (categoryId < 0)
                throw new Exception("Forbidden value on categoryId = " + categoryId + ", it doesn't respect the following condition : categoryId < 0");
            

}


}


}