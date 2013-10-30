using OptimusApi.Bot;
using OptimusApi.Bot.Game.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotApiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BotManager bot = new BotManager("ndc", "mdp", true);
            new test(bot);
            Console.Read();
        }

    }
}
