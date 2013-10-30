


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class HumanOptionEmote : HumanOption
{

public const short Id = 407;
public override short TypeId
{
    get { return Id; }
}

public sbyte emoteId;
        public double emoteStartTime;
        

public HumanOptionEmote()
{
}

public HumanOptionEmote(sbyte emoteId, double emoteStartTime)
        {
            this.emoteId = emoteId;
            this.emoteStartTime = emoteStartTime;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(emoteId);
            writer.WriteDouble(emoteStartTime);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            emoteId = reader.ReadSByte();
            emoteStartTime = reader.ReadDouble();
            

}


}


}