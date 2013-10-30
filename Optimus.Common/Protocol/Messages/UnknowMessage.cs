using Optimus.Common.IO;
using Optimus.Common.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimus.Common.Protocol.Messages
{
    public class UnknowMessage : NetworkMessage
    {
          public const uint Id = 10000;
          public override uint MessageId
          {
              get { return packetId; }
          }

          private uint packetId;
        public UnknowMessage(uint id)
        {
            this.packetId = id;
        }

        public override void Serialize(BigEndianWriter param1)
        {
        }

        public override void Deserialize(BigEndianReader param1)
        {
        }

    }
}
