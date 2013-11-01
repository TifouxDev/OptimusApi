using Optimus.Common.Dispatching;
using Optimus.Common.Enums;
using Optimus.Common.Protocol.Enums;
using Optimus.Common.Protocol.Messages;
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
        public int ContextualId { get; internal set; }
        public string Name { get; internal set; }
        public int CellId { get; internal set; }
        public int Direction { get; internal set; }
        public BreedEnum Breed { get; internal set; }
        public int Level { get; internal set; }
        public SexEnum Sex { get; internal set; }
        public Character()
        {
        }
        internal void Update(CharacterSelectedSuccessMessage packet)
        {
            CharacterBaseInformations message = (CharacterBaseInformations)packet.infos;
            ContextualId = message.id;
            Name = message.name;
            Breed = (BreedEnum)message.breed;
            Level = message.level;
            Sex = (SexEnum)Convert.ToInt16(message.sex);
        }
        internal void Update(GameRolePlayActorInformations message)
        {
            GameRolePlayCharacterInformations player = (GameRolePlayCharacterInformations)message;
            this.ContextualId = player.contextualId;
            this.Breed = (BreedEnum)player.look.bonesId;
            this.Name = player.name;
            this.Direction = player.disposition.direction;
            this.CellId = player.disposition.cellId;
        }
    }
}
