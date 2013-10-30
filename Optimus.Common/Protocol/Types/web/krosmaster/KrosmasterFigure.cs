


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class KrosmasterFigure
{

public const short Id = 397;
public virtual short TypeId
{
    get { return Id; }
}

public string uid;
        public short figure;
        public short pedestal;
        public bool bound;
        

public KrosmasterFigure()
{
}

public KrosmasterFigure(string uid, short figure, short pedestal, bool bound)
        {
            this.uid = uid;
            this.figure = figure;
            this.pedestal = pedestal;
            this.bound = bound;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(uid);
            writer.WriteShort(figure);
            writer.WriteShort(pedestal);
            writer.WriteBoolean(bound);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

uid = reader.ReadUTF();
            figure = reader.ReadShort();
            if (figure < 0)
                throw new Exception("Forbidden value on figure = " + figure + ", it doesn't respect the following condition : figure < 0");
            pedestal = reader.ReadShort();
            if (pedestal < 0)
                throw new Exception("Forbidden value on pedestal = " + pedestal + ", it doesn't respect the following condition : pedestal < 0");
            bound = reader.ReadBoolean();
            

}


}


}