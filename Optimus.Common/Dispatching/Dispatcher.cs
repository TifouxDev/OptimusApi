using Optimus.Common.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Optimus.Common.Dispatching
{
    public class Dispatcher
    {
        private readonly object locker = new object();
        private readonly List<MethodHandler> methods;
        private readonly Queue<NetworkMessage> queue;
        private Client client;
        public bool Running { get; private set; }

        public Dispatcher(Client client)
        {
            this.client = client;
            methods = new List<MethodHandler>();
            queue = new Queue<NetworkMessage>();
            client.MessageReceived += Enqueue;
            new Thread(Dispatch).Start();
        }

        public void Register(object @object)
        {
            lock (locker)
            {
                if (@object == null)
                {
                    throw new ArgumentNullException("object");
                }

                Type type = @object.GetType();

                foreach (var methodInfo in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
                {
                    MessageHandlerAttribute[] attributes = methodInfo.GetCustomAttributes<MessageHandlerAttribute>().ToArray();
                    if (attributes.Length != 0)
                    {
                        Register(methodInfo, @object, attributes);
                    }
                }
            }
        }

        public void Register(MethodInfo method, object instance, MessageHandlerAttribute[] attributes)
        {
            if (method == null)
            {
                throw new ArgumentNullException("method");
            }
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }
            if (attributes == null || attributes.Length == 0)
            {
                return;
            }

            ParameterInfo[] parameters = method.GetParameters();
            if (parameters.Length != 1)
            {
                throw new Exception(string.Format("Only one parameter is allowed to use the MessageHandler attribute. (method {0})", method.Name));
            }
            if (!parameters[0].ParameterType.IsSubclassOf(typeof(NetworkMessage)))
            {
                throw new Exception(string.Format("The parameter of a MessageHandler attribute must be a child of NetworkMessage. (method {0})", method.Name));
            }
            methods.Add(new MethodHandler(method, instance, attributes));
        }

        public void UnRegister(object @object)
        {
            methods.RemoveAll(entry => entry.Instance == @object);
        }

        private void Enqueue(object sender, NetworkMessage message)
        {
            queue.Enqueue(message);
        }

        private void Dispatch()
        {
            Running = true;

            while (Running)
            {
                Thread.Sleep(10);
                while (queue.Count != 0)
                {
                    NetworkMessage message = queue.Dequeue();
                    List<MethodHandler> functions = new List<MethodHandler>();
                    foreach (var method in methods.ToArray())
                    {
                        foreach (var attribute in method.Attributes)
                        {
                            if (attribute.MessageId == message.MessageId || attribute.MessageType == message.GetType())
                            {
                                functions.Add(method);
                                //method.Invoke(message);
                            }
                        }
                    }

                    // test nouveau système de traitement de packet par priority pas totalement sur.
                    IEnumerable<MethodHandler> test = functions.OrderByDescending(pet => pet.Attributes[0].Priority);
                    foreach(MethodHandler func in test)
                    {
                        func.Invoke(message);
                    }

                }
            }
        }
    }
}
