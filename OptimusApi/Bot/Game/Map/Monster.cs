using Optimus.Common.Protocol.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Bot.Game.Map
{
    public class Monster
    {
        public int ContextualId { get; private set; }
        public int CellId { get; private set; }
        public int Direction { get; private set; }
        public int ID { get; private set; }
        public Monster(GameRolePlayActorInformations actor)
        {
            GameRolePlayGroupMonsterInformations monster = (GameRolePlayGroupMonsterInformations)actor;
            this.ContextualId = monster.contextualId;
            this.CellId = monster.disposition.cellId;
            this.Direction = monster.disposition.direction;
            this.ID = monster.look.bonesId;
        }
    }
}
