using NLog;
using Optimus.Common.Dispatching;
using Optimus.Common.Enums;
using Optimus.Common.Protocol.Messages;
using OptimusApi.Bot.Interface.Tchat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// class non terminé!
namespace OptimusApi.Bot.Game.Tchat
{
    public delegate void MessageReceived(object sender, IMessenger message);
    public class BotMessenger
    {
        private BotManager bot;
        public event MessageReceived MessageReceived;
        public BotMessenger(BotManager client)
        {
            bot = client;
            bot.Network.Dispatcher.Register(this);
        }

        public void SendMessage(string message,  ChannelTchatEnum channel = ChannelTchatEnum.CHANNEL_GLOBAL)
        {
            ChatClientMultiMessage CCMM = new ChatClientMultiMessage(message, (sbyte)channel);
            bot.Network.Send(CCMM);
        }

        public void SendPrivateMessage(string message, string target)
        {
            ChatClientPrivateMessage ccpm = new ChatClientPrivateMessage(message, target);
            bot.Network.Send(ccpm);
        }

        [MessageHandler(TextInformationMessage.Id, PriorityPacket.VERY_HIGH)]
        private void HandlerTextInformationMessage(TextInformationMessage message)
        {

        }

        [MessageHandler(ChatServerMessage.Id, PriorityPacket.VERY_HIGH)]
        private void HandlerServerMessage(ChatServerMessage message)
        {
            IMessenger packet = new Messenger(message.senderName, message.content, (ChannelTchatEnum)(int)message.channel);
            if (this.MessageReceived != null)
            {
                    MessageReceived(this, packet);
            }
        }
    }
}
