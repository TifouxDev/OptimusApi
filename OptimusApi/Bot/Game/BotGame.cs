using OptimusApi.Bot.Game.Bot;
using OptimusApi.Bot.Game.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Bot.Game
{
    public class BotGame
    {
        private BotManager client;
        public World World { get; private set; }
        public Player Character { get; private set; }
        public BotGame(BotManager bot)
        {
            client = bot;
            World = new World(client);
            Character = new Player();
        }
       
    }
}
