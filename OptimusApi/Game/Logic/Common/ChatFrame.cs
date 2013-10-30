using Optimus.Common.Dispatching;
using Optimus.Common.Protocol.Messages;
using OptimusApi.Bot;
using OptimusApi.Bot.Interface;
using OptimusApi.Mics.InterClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Game.logic.common
{
    public class ChatFrame : IProtocol
    {
        public ChatFrame(BotManager bot)
        {
            client = bot;
            Register();
        }

        public void Register()
        {
            client.Network.Dispatcher.Register(this);
        }

        public BotManager client
        {
            get;
            set;
        }

        [MessageHandler(MailStatusMessage.Id)]
        public void HandlerMailStatusMessage(MailStatusMessage message)
        {
            client.Network.Send(new FriendsGetListMessage());
            client.Network.Send(new IgnoredGetListMessage());
            client.Network.Send(new SpouseGetInformationsMessage());

            FlashKey flashKey = new FlashKey();        
            client.Network.Send(new ClientKeyMessage(flashKey.GetRandomFlashKey()));

            client.Network.Send(new GameContextCreateRequestMessage());
        }

    }
}
