using Optimus.Common.Data;
using OptimusApi.Bot;
using OptimusApi.Bot.Game.Map;
using OptimusApi.Bot.Game.Tchat;
using OptimusApi.Tool.D2P;
using OptimusApi.Tool.D2P.Map;
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
            //Console.WriteLine(25021 & 4095); ;
            BotManager bot = new BotManager("ndc", "mdp", true);              
             new test(bot);
           new AuthentificationSuivie(bot);
            Console.Read();
        }

    }
}
