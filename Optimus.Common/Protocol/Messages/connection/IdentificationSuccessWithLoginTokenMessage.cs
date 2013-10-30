


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class IdentificationSuccessWithLoginTokenMessage : IdentificationSuccessMessage
{

public const uint Id = 6209;
public override uint MessageId
{
    get { return Id; }
}

public string loginToken;
        

public IdentificationSuccessWithLoginTokenMessage()
{
}

public IdentificationSuccessWithLoginTokenMessage(bool hasRights, bool wasAlreadyConnected, string login, string nickname, int accountId, sbyte communityId, string secretQuestion, double subscriptionEndDate, double accountCreation, string loginToken)
         : base(hasRights, wasAlreadyConnected, login, nickname, accountId, communityId, secretQuestion, subscriptionEndDate, accountCreation)
        {
            this.loginToken = loginToken;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(loginToken);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            loginToken = reader.ReadUTF();
            

}


}


}