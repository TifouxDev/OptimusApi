


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class BasicSetAwayModeRequestMessage : NetworkMessage
{

public const uint Id = 5665;
public override uint MessageId
{
    get { return Id; }
}

public bool enable;
        public bool invisible;
        

public BasicSetAwayModeRequestMessage()
{
}

public BasicSetAwayModeRequestMessage(bool enable, bool invisible)
        {
            this.enable = enable;
            this.invisible = invisible;
        }
        

public override void Serialize(BigEndianWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, enable);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, invisible);
            writer.WriteByte(flag1);
            

}

public override void Deserialize(BigEndianReader reader)
{

byte flag1 = reader.ReadByte();
            enable = BooleanByteWrapper.GetFlag(flag1, 0);
            invisible = BooleanByteWrapper.GetFlag(flag1, 1);
            

}


}


}