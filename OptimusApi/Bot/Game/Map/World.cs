using Optimus.Common.Dispatching;
using Optimus.Common.Protocol.Enums;
using Optimus.Common.Protocol.Messages;
using Optimus.Common.Protocol.Types;
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

        private BotManager client;

        // Evènement
        public event EventPlayerEnterMap PlayerEnterMap; // Des qu'il y a un nouveau joueur sur la map qui apparait l'evenement se lance!
       // public event EventPlayerQuitMap PlayerQuitMap;//Des qu'il y a un joueur qui quitte la map l'evenement se lance!
        public World(BotManager bot)
        {
            client = bot;
            bot.Network.Dispatcher.Register(this);
        }

        [MessageHandler(CurrentMapMessage.Id, Optimus.Common.Enums.PriorityPacket.VERY_HIGH)]
        public void HandleCurrentMap(CurrentMapMessage message)
        {
            int CurrentMapid = message.mapId;
            MapID = CurrentMapid;
            client.Network.Send(new MapInformationsRequestMessage(CurrentMapid));
            Optimus.Common.Log.Logger.GetInstance("Player{Debug}").Debug(string.Format("Current mapId is {0}.", CurrentMapid));
        }

        [MessageHandler(MapComplementaryInformationsDataMessage.Id, Optimus.Common.Enums.PriorityPacket.VERY_HIGH)]
        public void HandlerMapInformation(MapComplementaryInformationsDataMessage message)
        {
            List<Character> players = new List<Character>();
            List<Monster> monsters  = new List<Monster>();

            foreach (GameRolePlayActorInformations player in message.actors)
            {
                switch (player.TypeId)
                {
                    case 36: // joueur
                        players.Add(new Character(player));
                        if (player.contextualId == client.Game.Character.ContextualId) // si c'est le bot on initialize la cellide et direction
                        {
                            client.Game.Character.CellId = player.disposition.cellId;
                            client.Game.Character.Direction = player.disposition.direction;
                        }
                    break;

                    case 160: // montre
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
        public void HandlerActorShow(GameRolePlayShowActorMessage message)
        {
            if (PlayerEnterMap != null){
                if (message.informations.TypeId == 36) 
                { 
                    PlayerEnterMap(this, new Character(message.informations));
                }
            }

            Optimus.Common.Log.Logger.GetInstance(string.Format("Bot[{0}]=>", client.Account.Name)).Debug("Nouveaux personnage sur la carte!");
        }

        [MessageHandler(CharacterSelectedSuccessMessage.Id, Optimus.Common.Enums.PriorityPacket.VERY_HIGH)]
        public void CharacterSelected(CharacterSelectedSuccessMessage message)
        {
            client.Game.Character.IniCharacterBaseInformation(message.infos);
        }


    }
}
