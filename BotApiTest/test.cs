using Optimus.Common.Dispatching;
using Optimus.Common.Protocol.Messages;
using OptimusApi.Bot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BotApiTest
{
    class test
    {
        private BotManager bot; 
        public test(BotManager client)
        {
            bot = client;
            bot.Network.Dispatcher.Register(this);
        }

        [MessageHandler(MapComplementaryInformationsDataMessage.Id)]
        public void MapLoaded(MapComplementaryInformationsDataMessage message)
        {
            new Thread(SendTest).Start();
        }

        //test tchat
        private void SendTest()
        {
            bot.Game.World.Tchat.SendMessage("Salut", Optimus.Common.Enums.ChannelTchatEnum.CHANNEL_GLOBAL);
            Thread.Sleep(500);
            bot.Game.World.Tchat.SendPrivateMessage("Salut copain", "Baalis");
        }
    }
}
