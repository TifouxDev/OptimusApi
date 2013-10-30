


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TaxCollectorListMessage : NetworkMessage
{

public const uint Id = 5930;
public override uint MessageId
{
    get { return Id; }
}

public sbyte nbcollectorMax;
        public Types.TaxCollectorInformations[] informations;
        public Types.TaxCollectorFightersInformation[] fightersInformations;
        

public TaxCollectorListMessage()
{
}

public TaxCollectorListMessage(sbyte nbcollectorMax, Types.TaxCollectorInformations[] informations, Types.TaxCollectorFightersInformation[] fightersInformations)
        {
            this.nbcollectorMax = nbcollectorMax;
            this.informations = informations;
            this.fightersInformations = fightersInformations;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(nbcollectorMax);
            writer.WriteUShort((ushort)informations.Length);
            foreach (var entry in informations)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)fightersInformations.Length);
            foreach (var entry in fightersInformations)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

nbcollectorMax = reader.ReadSByte();
            if (nbcollectorMax < 0)
                throw new Exception("Forbidden value on nbcollectorMax = " + nbcollectorMax + ", it doesn't respect the following condition : nbcollectorMax < 0");
            var limit = reader.ReadUShort();
            informations = new Types.TaxCollectorInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 informations[i] = Types.ProtocolTypeManager.GetInstance<Types.TaxCollectorInformations>(reader.ReadShort());
                 informations[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            fightersInformations = new Types.TaxCollectorFightersInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 fightersInformations[i] = new Types.TaxCollectorFightersInformation();
                 fightersInformations[i].Deserialize(reader);
            }
            

}


}


}