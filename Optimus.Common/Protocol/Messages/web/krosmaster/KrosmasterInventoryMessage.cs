


















// Generated on 10/27/2013 07:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class KrosmasterInventoryMessage : NetworkMessage
{

public const uint Id = 6350;
public override uint MessageId
{
    get { return Id; }
}

public Types.KrosmasterFigure[] figures;
        

public KrosmasterInventoryMessage()
{
}

public KrosmasterInventoryMessage(Types.KrosmasterFigure[] figures)
        {
            this.figures = figures;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)figures.Length);
            foreach (var entry in figures)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            figures = new Types.KrosmasterFigure[limit];
            for (int i = 0; i < limit; i++)
            {
                 figures[i] = new Types.KrosmasterFigure();
                 figures[i].Deserialize(reader);
            }
            

}


}


}