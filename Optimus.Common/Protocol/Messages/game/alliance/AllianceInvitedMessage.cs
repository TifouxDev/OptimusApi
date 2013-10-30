


















// Generated on 10/27/2013 07:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AllianceInvitedMessage : NetworkMessage
{

public const uint Id = 6397;
public override uint MessageId
{
    get { return Id; }
}

public int recruterId;
        public string recruterName;
        public Types.BasicNamedAllianceInformations allianceInfo;
        

public AllianceInvitedMessage()
{
}

public AllianceInvitedMessage(int recruterId, string recruterName, Types.BasicNamedAllianceInformations allianceInfo)
        {
            this.recruterId = recruterId;
            this.recruterName = recruterName;
            this.allianceInfo = allianceInfo;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(recruterId);
            writer.WriteUTF(recruterName);
            allianceInfo.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

recruterId = reader.ReadInt();
            if (recruterId < 0)
                throw new Exception("Forbidden value on recruterId = " + recruterId + ", it doesn't respect the following condition : recruterId < 0");
            recruterName = reader.ReadUTF();
            allianceInfo = new Types.BasicNamedAllianceInformations();
            allianceInfo.Deserialize(reader);
            

}


}


}