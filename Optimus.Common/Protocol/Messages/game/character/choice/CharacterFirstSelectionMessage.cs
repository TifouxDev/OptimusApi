


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class CharacterFirstSelectionMessage : CharacterSelectionMessage
{

public const uint Id = 6084;
public override uint MessageId
{
    get { return Id; }
}

public bool doTutorial;
        

public CharacterFirstSelectionMessage()
{
}

public CharacterFirstSelectionMessage(int id, bool doTutorial)
         : base(id)
        {
            this.doTutorial = doTutorial;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(doTutorial);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            doTutorial = reader.ReadBoolean();
            

}


}


}