using Optimus.Common.Dispatching;
using Optimus.Common.IO;
using Optimus.Common.Protocol;
using Optimus.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Optimus.Common.Network
{
    public delegate void MessageReceivedEventHandler(object sender, NetworkMessage message);

    public class Client
    {
        private object locker;

        public Dispatcher Dispatcher { get; private set; }
        public TcpClient Socket { get; private set; }
        public bool Running { get; private set; }
        public BigEndianWriter Writer { get; private set; }
        public BigEndianReader Reader { get; private set; }

        //Latency Manager
        private List<int> pauseBuffer;
        private  List<int>  latencyBuffer;
        private uint latestSent;
        public uint LastSent{get; private set;}
        private int startTimer;
        private int sendSequenceId;

        //Sequen
        private uint synchroStep = 0;

        //Debug
        private NLog.Logger log;


        public bool Connected
        {
            get { return Socket != null && Socket.Connected; }
        }

        public Client()
        {
            reloadLatency();
            locker = new object();
            Socket = new TcpClient();
            Dispatcher = new Dispatcher(this);
            log = Log.Logger.GetInstance("(Bot) => ");
        }


        private void reloadLatency()
        {
            startTimer = DateTime.Now.Millisecond;
            sendSequenceId = 0;
            pauseBuffer = new List<int>();
            latencyBuffer = new List<int>();
        }

        public Client(TcpClient client)
        {
            locker = new object();
            Socket = client;
            Running = true;
            Dispatcher = new Dispatcher(this);

            Reader = new BigEndianReader(Socket.GetStream());
            Writer = new BigEndianWriter(Socket.GetStream());
            new Task(Listen).Start();
        }

        public event MessageReceivedEventHandler MessageReceived;
        public event Action<Client> ClientConnected;
        public event Action<Client> ClientDisconnected;

        /// <summary>
        ///     Connects the client to the specified port on the specified host.
        /// </summary>
        /// <param name="hostname">The DNS name of the remote host to which you intend to connect.</param>
        /// <param name="port">The port number of the remote host to which you intend to connect.</param>
        public bool Start(string hostname, int port)
        {
            if (Running)
                throw new Exception("The client is already running.");
            try
            {
                Socket.Connect(hostname, port);
            }
            catch (Exception)
            {
                return false;
            }
            Reader = new BigEndianReader(Socket.GetStream());
            Writer = new BigEndianWriter(Socket.GetStream());
            Running = true;

            new Task(Listen).Start();
            return true;
        }

        /// <summary>
        ///     Disposes the socket instance and requests that the underlying TCP connection be closed.
        /// </summary>
        public void Stop()
        {
            Socket.Close();
            Running = false;
        }

        /// <summary>
        ///     Sends a message to the server
        /// </summary>
        public void Send(NetworkMessage message)
        {
            lock (locker)
            {
                if (!Connected)
                    return;
                using (BigEndianWriter writer = new BigEndianWriter())
                {
                    message.Pack(writer);
                    Writer.WriteBytes(writer.Data);
                }
            }
        }

        public void Send(byte[] bits)
        {
            lock (locker)
            {
                if (!Connected)
                    return;
                using (BigEndianWriter writer = new BigEndianWriter())
                {
                    Writer.WriteBytes(bits);
                }
                LowSend();
            }
        }
        public void Send(uint id, byte[] data)
        {
            lock (locker)
            {
                if (!Connected)
                    throw new Exception("Cannot send a message if the client isn't connected.");
                Writer.WriteBytes(NetworkMessage.BuildPacket(id, data));
                LowSend();
            }
        }
    
        protected virtual void OnMessageReceived(NetworkMessage message)
        {
          //  log.Debug(string.Format("Packet Id : {0}, lenght : {1}", message.MessageId, message.Data.Length));
            MessageReceivedEventHandler handler = MessageReceived;
            if (handler != null) handler(this, message);
        }

        protected virtual void OnClientDisconnected()
        {
            log.Fatal("Player disconnected");
            Running = false;
            Action<Client> handler = ClientDisconnected;
            if (handler != null) handler(this);
        }

        protected virtual void OnClientConnected()
        {
            Running = true;
            Action<Client> handler = ClientConnected;
            if (handler != null) handler(this);
        }

        private void Listen()
        {
            OnClientConnected();

            while (Running && Connected)
            {
                try
                {
                    Thread.Sleep(50);
                    OnMessageReceived(MessageBuilder.Build(Reader));
                }
                catch (Exception)
                {
                    break;
                }
            }

            Running = false;
            OnClientDisconnected();
        }

        public void Reconnect(string ip, uint port)
        {
            Socket.Close();
            Running = false;
            locker = new object();
            Socket = new TcpClient();
            Dispatcher = new Dispatcher(this);
            Start(ip, (int)port);
            Dispatcher.Register(this);
        }

        public uint LatencyAvg()
        {
            if (this.latencyBuffer.Count == 0)
                return 0;

            var _loc1_ = 0;
            foreach (var value in this.latencyBuffer)
            {
                _loc1_ += _loc1_ + value;
            }

            return (uint)(_loc1_ / this.latencyBuffer.Count);
        }
      
        public uint LatencySamplesCount()
        {
            return (uint)this.latencyBuffer.Count;
        }

        public void LowSend()
        {
            this.latestSent = GetTimer();
            this.LastSent = GetTimer();
            this.sendSequenceId++;
        }

        private uint GetTimer()
        {
            return (uint)(DateTime.Now.Millisecond - startTimer);
        }

        private uint GetTimer(int elapse)
        {
            return (uint)(DateTime.Now.Millisecond - elapse);
        }

        public uint LatencySamplesMax()
        {
            return 50;
        }

        [MessageHandler(SequenceNumberRequestMessage.Id)]
        public void SequenceNumber(SequenceNumberRequestMessage message)
        {
            this.sendSequenceId++;
            SequenceNumberMessage reponse = new SequenceNumberMessage((ushort)sendSequenceId);
            this.Send(reponse);
        }

        private string GetTime()
        {
            return string.Format("[{0}]", DateTime.Now.ToString("HH:mm:ss"));
        }

        private void WriteInConsole(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(GetTime() + " => ");
            Console.ForegroundColor = color;
            Console.Write(message + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
      }
    }

