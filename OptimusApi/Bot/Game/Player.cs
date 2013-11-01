using Optimus.Common.Dispatching;
using Optimus.Common.Enums;
using Optimus.Common.Protocol.Messages;
using Optimus.Common.Protocol.Types;
using OptimusApi.Bot.Game.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Bot.Game
{
    // class non terminé!
    public class Player : Character
    {
        private BotManager bot;
        public Player(BotManager client)
            : base()
        {
            bot = client;
        }

        public void Move(int cellId)
        {

        }

        public void Move(MapDirection direction)
        {

        }

        [MessageHandler(CharacterSelectedSuccessMessage.Id, PriorityPacket.VERY_HIGH)]
        private void CharactedSelected(CharacterSelectedSuccessMessage message)
        {
            bot.Game.Character.Update(message);
        }
    }
}
