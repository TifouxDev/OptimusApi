


















// Generated on 10/27/2013 07:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class HumanOptionTitle : HumanOption
{

public const short Id = 408;
public override short TypeId
{
    get { return Id; }
}

public short titleId;
        public string titleParam;
        

public HumanOptionTitle()
{
}

public HumanOptionTitle(short titleId, string titleParam)
        {
            this.titleId = titleId;
            this.titleParam = titleParam;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(titleId);
            writer.WriteUTF(titleParam);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            titleId = reader.ReadShort();
            if (titleId < 0)
                throw new Exception("Forbidden value on titleId = " + titleId + ", it doesn't respect the following condition : titleId < 0");
            titleParam = reader.ReadUTF();
            

}


}


}