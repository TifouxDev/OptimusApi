


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class JobCrafterDirectoryDefineSettingsMessage : NetworkMessage
{

public const uint Id = 5649;
public override uint MessageId
{
    get { return Id; }
}

public Types.JobCrafterDirectorySettings settings;
        

public JobCrafterDirectoryDefineSettingsMessage()
{
}

public JobCrafterDirectoryDefineSettingsMessage(Types.JobCrafterDirectorySettings settings)
        {
            this.settings = settings;
        }
        

public override void Serialize(BigEndianWriter writer)
{

settings.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

settings = new Types.JobCrafterDirectorySettings();
            settings.Deserialize(reader);
            

}


}


}