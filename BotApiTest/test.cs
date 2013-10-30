using Optimus.Common.Dispatching;
using Optimus.Common.Protocol.Messages;
using OptimusApi.Bot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            NLog.Logger log = Optimus.Common.Log.Logger.GetInstance("BotAPItest");
            log.Debug(string.Format("Character name {0}\n level {1} sex {2}", bot.Game.Character.Name, bot.Game.Character.Level, bot.Game.Character.Sex.ToString()));
        }
    }
}
