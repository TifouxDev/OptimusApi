using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Optimus.Common.Protocol.Types
{
    internal class ProtocolTypeManager
    {
        private static Dictionary<int, Type> types;
        private static bool initialized;

        public static T GetInstance<T>(short id) where T : class
        {
            if (!initialized)
                Init();
            if (!types.ContainsKey(id))
                throw new Exception("Unknow Protocol Type id " + id);

            return Activator.CreateInstance(types[id]) as T;
        }

        private static void Init()
        {
            if (initialized) return;
            types = new Dictionary<int, Type>();

            Assembly assembly = Assembly.GetAssembly(typeof(ProtocolTypeManager));

            foreach (var type in assembly.GetTypes())
            {
                if (type.Namespace != null && type.Namespace.Contains("Optimus.Common.Protocol.Types"))
                {
                    FieldInfo fieldId = type.GetField("Id");
                    if (fieldId != null)
                    {
                        short id = (short)fieldId.GetValue(type);
                        if (types.ContainsKey(id))
                        {
                            throw new AmbiguousMatchException(string.Format("The message with id {0} is already registered.", id));
                        }
                        types.Add(id, type);
                    }
                }
            }
            initialized = true;
        }
    }
}
