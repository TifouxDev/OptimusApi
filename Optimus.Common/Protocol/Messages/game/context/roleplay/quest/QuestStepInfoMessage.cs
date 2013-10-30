


















// Generated on 10/27/2013 07:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class QuestStepInfoMessage : NetworkMessage
{

public const uint Id = 5625;
public override uint MessageId
{
    get { return Id; }
}

public Types.QuestActiveInformations infos;
        

public QuestStepInfoMessage()
{
}

public QuestStepInfoMessage(Types.QuestActiveInformations infos)
        {
            this.infos = infos;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

infos = Types.ProtocolTypeManager.GetInstance<Types.QuestActiveInformations>(reader.ReadShort());
            infos.Deserialize(reader);
            

}


}


}