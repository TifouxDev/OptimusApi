using Optimus.Common.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Optimus.Common.Dispatching
{
    public class MethodHandler
    {
        public MethodInfo Method { get; private set; }
        public object Instance { get; private set; }
        public MessageHandlerAttribute[] Attributes { get; private set; }

        public MethodHandler(MethodInfo method, object instance, MessageHandlerAttribute[] attributes)
        {
            Method = method;
            Instance = instance;
            Attributes = attributes;
        }

        public void Invoke(NetworkMessage message)
        {
            Method.Invoke(Instance, new object[] { message });
        }
    }
}
