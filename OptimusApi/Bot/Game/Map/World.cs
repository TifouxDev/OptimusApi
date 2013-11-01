using Optimus.Common.Dispatching;
using Optimus.Common.Protocol.Enums;
using Optimus.Common.Protocol.Messages;
using Optimus.Common.Protocol.Types;
using OptimusApi.Bot.Game.Tchat;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Bot.Game.Map
{
    public delegate void EventPlayerEnterMap(object sender, Character player);
    public delegate void EventPlayerQuitMap(object sender, Character player);

    public class World
    {
        public int MapID {get; private set;}
        public Character[] Players { get; private set; }
        public Monster[] Monsters { get; private set; }
        public Point Position { get; private set; }
        public BotMessenger Tchat { get; private set; }

        private BotManager client;

        // Evènement
        public event EventPlayerEnterMap PlayerEnterMap; // Des qu'il y a un nouveau joueur sur la map qui apparait l'evenement se lance!
       // public event EventPlayerQuitMap PlayerQuitMap;//Des qu'il y a un joueur qui quitte la map l'evenement se lance!
        public World(BotManager bot)
        {
            client = bot;
            bot.Network.Dispatcher.Register(this);
            Tchat = new BotMessenger(client);
        }

        [MessageHandler(CurrentMapMessage.Id, Optimus.Common.Enums.PriorityPacket.VERY_HIGH)]
        private void HandleCurrentMap(CurrentMapMessage message)
        {
            int CurrentMapid = message.mapId;
            MapID = CurrentMapid;
            client.Network.Send(new MapInformationsRequestMessage(CurrentMapid));
            Optimus.Common.Log.Logger.GetInstance("Player{Debug}").Debug(string.Format("Current mapId is {0}.", CurrentMapid));
        }

        [MessageHandler(MapComplementaryInformationsDataMessage.Id, Optimus.Common.Enums.PriorityPacket.VERY_HIGH)]
        private void HandlerMapInformation(MapComplementaryInformationsDataMessage message)
        {
            List<Character> players = new List<Character>();
            List<Monster> monsters  = new List<Monster>();
            foreach (GameRolePlayActorInformations player in message.actors)
            {
                switch (player.TypeId)
                {
                    case 36: // joueur
                        if (client.Game.Character.ContextualId == player.contextualId)
                        {
                            client.Game.Character.Update(player);
                        }
                        Character actor = new Character();
                        actor.Update(player);
                    break;

                    case 160: // monstre
                        monsters.Add(new Monster(player));
                    break;

                    case 156: // pnj
                        GameRolePlayNpcInformations npc = (GameRolePlayNpcInformations)player;
                    break;
                }
            }

            this.Players = players.ToArray();
            this.Monsters = monsters.ToArray();
            Optimus.Common.Log.Logger.GetInstance("Player{Debug}").Debug(string.Format("They are {0} player(s) on the map and {1} house!", message.actors.Length, message.houses.Length));
        }

        [MessageHandler(GameRolePlayShowActorMessage.Id, Optimus.Common.Enums.PriorityPacket.VERY_HIGH)]
        private void HandlerActorShow(GameRolePlayShowActorMessage message)
        {
            if (PlayerEnterMap != null){
                if (message.informations.TypeId == 36) 
                {
                    Character c = new Character();
                    c.Update(message.informations);
                    PlayerEnterMap(this, c);
                }
            }
            Optimus.Common.Log.Logger.GetInstance(string.Format("Bot[{0}]=>", client.Account.Name)).Debug("Nouveaux personnage sur la carte!");
        }

    }
}
