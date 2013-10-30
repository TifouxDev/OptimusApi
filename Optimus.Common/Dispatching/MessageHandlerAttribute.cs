using Optimus.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimus.Common.Dispatching
{
    public class MessageHandlerAttribute : Attribute
    {
        public Type MessageType { get; private set; }
        public uint MessageId { get; private set; }
        public PriorityPacket Priority { get; private set; }
        public MessageHandlerAttribute(Type type)
        {
            MessageType = type;
        }

        public MessageHandlerAttribute(uint id, PriorityPacket priority = PriorityPacket.DEFAULT)
        {
            MessageId = id;
            Priority = priority;
        }
    }
}
