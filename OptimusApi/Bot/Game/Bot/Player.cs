using Optimus.Common.Protocol.Types;
using OptimusApi.Bot.Game.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Bot.Game.Bot
{
    public class Player : Character
    {
        public Player()
            : base()
        {

        }

        public Player(GameRolePlayActorInformations player)
            : base(player)
        {

        }

    }
}
