using Optimus.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Bot.Interface.Tchat
{
    public class Messenger : IMessenger
    {
        private string senderName = string.Empty;
        private string content = string.Empty;
        private ChannelTchatEnum channelMessage;
        public Messenger(string author, string message, ChannelTchatEnum channel)
        {
            senderName = author;
            content = message;
            channelMessage = channel;
        }

        public string Author
        {
            get { return senderName; }
        }

        public string Message
        {
            get { return content; }
        }

        public ChannelTchatEnum Channel
        {
            get { return channelMessage; }
        }
    }
}
