


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class IdentificationAccountForceMessage : IdentificationMessage
{

public const uint Id = 6119;
public override uint MessageId
{
    get { return Id; }
}

public string forcedAccountLogin;
        

public IdentificationAccountForceMessage()
{
}

public IdentificationAccountForceMessage(bool autoconnect, bool useCertificate, bool useLoginToken, Types.VersionExtended version, string lang, sbyte[] credentials, short serverId, double sessionOptionalSalt, string forcedAccountLogin)
         : base(autoconnect, useCertificate, useLoginToken, version, lang, credentials, serverId, sessionOptionalSalt)
        {
            this.forcedAccountLogin = forcedAccountLogin;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(forcedAccountLogin);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            forcedAccountLogin = reader.ReadUTF();
            

}


}


}