using Optimus.Common.Enums;
using Optimus.Common.Protocol.Enums;
using Optimus.Common.Protocol.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Bot.Game.Map
{
    public class Character
    {
        public int ContextualId { get; private set; }
        public string Name { get;  set; }
        public int CellId { get;  set; }
        public int Direction { get;  set; }
        public BreedEnum Breed { get;  set; }
        public int Level { get; set; }
        public SexEnum Sex { get; set; }
        public Character(){
        }
        public Character(GameRolePlayActorInformations actor)
        {
            GameRolePlayNamedActorInformations player = (GameRolePlayNamedActorInformations)actor;
            this.ContextualId = player.contextualId;
            this.Breed = (BreedEnum)player.look.bonesId;
            this.Name = player.name;
            this.Direction = player.disposition.direction;
            this.CellId = player.disposition.cellId;
        }
        public void IniCharacterBaseInformation(CharacterBaseInformations message)
        {
            ContextualId = message.id;
            Name = message.name;
            Breed = (BreedEnum)message.breed;
            Level = message.level;
            Sex = (SexEnum)Convert.ToInt16(message.sex);
        }
    }
}
