using Optimus.Common.Dispatching;
using Optimus.Common.Network;
using Optimus.Common.Protocol.Messages;
using OptimusApi.Bot.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Bot
{
    public class BotManager
    {
        public AccountInformation Account{ get; private set; }
        public Client Network { get; private set; }
        public Bot.Game.BotGame Game { get; private set; }

        public BotManager(string accountName, string accountPassword, bool autoConnect = false)
        {
            Account = new AccountInformation(accountName, accountPassword);
            Network = new Client();
            Game = new Bot.Game.BotGame(this);
            Network.Dispatcher.Register(new Login.AuthentificationMessage(this));
            if (autoConnect){
                this.Start();
            }
        }

        public void Start()
        {
            this.Network.Start("213.248.126.40", 5555);
        }

    }
}
