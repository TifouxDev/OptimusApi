using Optimus.Common.Dispatching;
using Optimus.Common.Protocol.Messages;
using OptimusApi.Bot;
using OptimusApi.Bot.Game.Tchat;
using OptimusApi.Tool.D2P;
using OptimusApi.Tool.D2P.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BotApiTest
{
    public class test
    {
        private BotManager bot; 
        public test(BotManager client)
        {
            bot = client;
            bot.BotGameConnected += new BotConnectedGame(Connected);
        }

        private void Connected(object sender)
        {
            bot.Network.Dispatcher.Register(this);
            bot.Game.World.Tchat.MessageReceived += new MessageReceived(Tchat_MessageReceived);
        }

        [MessageHandler(MapComplementaryInformationsDataMessage.Id)]
        public void MapLoaded(MapComplementaryInformationsDataMessage message)
        {
            new Thread(SendTest).Start();
        }

        //test tchat
        private void SendTest()
        {
         //  Thread.Sleep(500);
           // bot.Game.World.Tchat.SendMessage("sa m'enerve", Optimus.Common.Enums.ChannelTchatEnum.CHANNEL_GLOBAL);
            Thread.Sleep(500);
            MapManager map  = new MapManager(@"C:\Program Files (x86)\Dofus2\app\content\maps");
            Map currentMap = map.GetMap(bot.Game.World.MapID);
            Pathfinding.Pathfinding pathfinder = new Pathfinding.Pathfinding(bot.Game.Character.CellId, 326, currentMap);
            GameMapMovementRequestMessage gmmrm = new GameMapMovementRequestMessage(pathfinder.GetPath().ToArray(), bot.Game.World.MapID);
            bot.Network.Send(gmmrm);
            if(pathfinder.LenghtPath <= 2){
                Thread.Sleep(450 * pathfinder.LenghtPath);
            }else{
                      Thread.Sleep(200 * pathfinder.LenghtPath);
            }
            bot.Network.Send(new GameMapMovementConfirmMessage());
        }

        private void Tchat_MessageReceived(object sender, OptimusApi.Bot.Interface.Tchat.IMessenger message)
        {
            Console.WriteLine(string.Format("[{0}] {1} : {2}", message.Channel.ToString(), message.Author, message.Message));
        }
    }
}
