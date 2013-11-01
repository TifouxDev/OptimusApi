using Optimus.Common.Data;
using OptimusApi.Bot;
using OptimusApi.Bot.Game.Map;
using OptimusApi.Bot.Game.Tchat;
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
            bot.Game.World.Tchat.MessageReceived += new MessageReceived(Tchat_MessageReceived);
            while (true)
            {
          
            }
        }
        
        private static void Tchat_MessageReceived(object sender, OptimusApi.Bot.Interface.Tchat.IMessenger message)
        {
            Console.WriteLine(string.Format("[{0}] {1} : {2}", message.Channel.ToString(), message.Author, message.Message));
        }

    }
}
